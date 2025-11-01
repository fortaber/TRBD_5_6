using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace BD_1_2
{
    public partial class InsEdit : Form
    {
        private SQLiteConnection sqliteConn;
        private string tableName;
        private int[] recordId;
        private DataTable schemaTable;
        private bool isInsForm;

        public InsEdit()
        {
            InitializeComponent();
        }

        public InsEdit(SQLiteConnection connection, string tableName, int[] id, bool isInsForm)
        {
            InitializeComponent();
            this.sqliteConn = connection;
            this.tableName = tableName;
            this.recordId = id;
            this.isInsForm = isInsForm;

            this.Text = isInsForm ? $"Добавление записи в {tableName}" : $"Редактирование записи в {tableName}";

            LoadTableSchema();
            CreateFormFields();
            if (!isInsForm)
                LoadRecordData();
        }

        private void LoadTableSchema()
        {
            schemaTable = new DataTable();
            string query = $"PRAGMA table_info({tableName})";
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, sqliteConn);
            adapter.Fill(schemaTable);
        }

        private void CreateFormFields()
        {
            int yPos = 20;

            foreach (DataRow column in schemaTable.Rows)
            {
                string columnName = column["name"].ToString();
                string columnType = column["type"].ToString().ToLower();

                if (Convert.ToInt32(column["pk"]) == 1 && tableName != "Movie_Genre")
                    continue;

                Label label = new Label();
                label.Text = GetDisplayName(columnName);
                label.Location = new Point(20, yPos);
                label.Size = new Size(150, 20);
                this.Controls.Add(label);

                Control inputControl = CreateInputControl(columnName, columnType);
                inputControl.Location = new Point(180, yPos);
                inputControl.Size = new Size(200, 20);
                inputControl.Name = columnName;
                this.Controls.Add(inputControl);

                yPos += 30;
            }
        }

        private string GetDisplayName(string columnName)
        {
            var displayNames = new Dictionary<string, string>
            {
                {"fk_id_age_rating", "Возрастной рейтинг"},
                {"fk_id_hall_type", "Тип зала"},
                {"fk_id_cinema_hall", "Кинозал"},
                {"fk_id_movie", "Фильм"},
                {"fk_id_session", "Сеанс"},
                {"fk_id_seat", "Место"},
                {"fk_id_client", "Клиент"},
                {"name", "Название"},
                {"client_full_name", "ФИО клиента"},
                {"client_date_of_birth", "Дата рождения"},
                {"date_session", "Дата сеанса"},
                {"start_time", "Время начала"},
                {"release_year", "Год выпуска"},
                {"age_rating", "Возрастной рейтинг"},
                {"min_age", "Минимальный возраст"},
                {"hall_type", "Тип зала"},
                {"row_number", "Количество рядов"},
                {"seat_number_in_row", "Мест в ряду"},
                {"available", "Доступен"},
                {"duration", "Длительность (мин)"},
                {"rating", "Рейтинг"},
                {"genre", "Жанр"},
                {"email", "Эл. почта"},
                {"phone", "Номер телефона"},
                {"price", "Цена"},
                {"status", "Статус"},
                {"buy_date", "Дата покупки"},
                {"row", "Ряд"},
                {"seat_in_row", "Место в ряду"},
                {"report", "Отчет"},
                {"id_genre", "Жанр"},
                {"id_movie", "Фильм"}
            };

            return displayNames.ContainsKey(columnName) ? displayNames[columnName] : columnName;
        }

        private Control CreateInputControl(string columnName, string columnType)
        {
            if (columnName == "status" && tableName == "Tickets")
            {
                return CreateStatusComboBox();
            }

            if (columnName == "available" && tableName == "Cinema_Halls")
            {
                return CreateAvailableComboBox();
            }

            if (columnName.StartsWith("fk_id_") || tableName == "Movie_Genre")
            {
                return CreateComboBoxForForeignKey(columnName);
            }

            switch (columnType)
            {
                case "text":
                    if (columnName.Contains("date"))
                    {
                        DateTimePicker dtp = new DateTimePicker();

                        if (columnName == "client_date_of_birth")
                            dtp.MinDate = new DateTime(1900, 1, 1);
                        else
                            dtp.MinDate = new DateTime(2020, 1, 1);

                        if (columnName == "buy_date" || columnName == "client_date_of_birth")
                            dtp.MaxDate = DateTime.Now.AddDays(1);
                        else
                            dtp.MaxDate = new DateTime(2100, 1, 1);
                        return dtp;
                    }
                    if (columnName.Contains("time"))
                    {
                        DateTimePicker dtp = new DateTimePicker();
                        dtp.Format = DateTimePickerFormat.Time;
                        dtp.CustomFormat = "HH:mm";
                        dtp.ShowUpDown = true;
                        return dtp;
                    }
                    if (columnName.Contains("email"))
                    {
                        TextBox tb = new TextBox();
                        tb.Validating += Email_Validating;
                        tb.MaxLength = 100;
                        return tb;
                    }
                    if (columnName.Contains("phone"))
                    {
                        MaskedTextBox mtb = new MaskedTextBox();
                        mtb.Mask = "+7-000-000-00-00";
                        return mtb;
                    }
                    else
                    {
                        TextBox tb = new TextBox();
                        switch (columnName)
                        {
                            case "hall_type": tb.MaxLength = 30; break;
                            case "age_rating": tb.MaxLength = 10; break;
                            case "genre": tb.MaxLength = 50; break;
                            case "name": tb.MaxLength = 100; break;
                            case "client_full_name": tb.MaxLength = 100; break;
                            case "report": tb.MaxLength = 200; break;
                            default: tb.MaxLength = 255; break;
                        }
                        return tb;
                    }

                case "integer":
                    NumericUpDown n = new NumericUpDown();
                    switch (columnName)
                    {
                        case "min_age":
                            n.Minimum = 0;
                            n.Maximum = 21;
                            break;
                        case "row_number":
                            n.Minimum = 1;
                            n.Maximum = 100;
                            break;
                        case "seat_number_in_row":
                            n.Minimum = 1;
                            n.Maximum = 100;
                            break;
                        case "duration":
                            n.Minimum = 1;
                            n.Maximum = 480;
                            break;
                        case "release_year":
                            n.Minimum = 1890;
                            n.Maximum = DateTime.Now.Year;
                            break;
                        case "row":
                            n.Minimum = 1;
                            n.Maximum = 1000;
                            break;
                        case "seat_in_row":
                            n.Minimum = 1;
                            n.Maximum = 1000;
                            break;
                        default:
                            n.Minimum = 0;
                            n.Maximum = 1000000;
                            break;
                    }
                    return n;

                case "real":
                    NumericUpDown nr = new NumericUpDown();
                    nr.DecimalPlaces = 2;
                    switch (columnName)
                    {
                        case "rating":
                            nr.Minimum = 1;
                            nr.Maximum = 10;
                            nr.DecimalPlaces = 1;
                            break;
                        case "price":
                            nr.Minimum = 0;
                            nr.Maximum = 10000;
                            break;
                        default:
                            nr.Minimum = 0;
                            nr.Maximum = 1000000;
                            break;
                    }
                    return nr;

                case "blob":
                    CheckBox checkBox = new CheckBox();
                    checkBox.Text = "";
                    return checkBox;

                default:
                    TextBox defaultTb = new TextBox();
                    defaultTb.MaxLength = 255;
                    return defaultTb;
            }
        }

        private void Email_Validating(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox == null) return;

            string email = textBox.Text.Trim();

            if (!string.IsNullOrEmpty(email) && !IsValidEmail(email))
            {
                textBox.BackColor = Color.LightPink;
            }
            else
            {
                textBox.BackColor = Color.White;
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var mail = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private bool IsPhoneComplete(string phone)
        {
            if (string.IsNullOrEmpty(phone))
                return false;

            string cleanPhone = phone.Replace("+7-", "").Replace("-", "");
            int digitCount = 0;

            foreach (char c in cleanPhone)
            {
                if (char.IsDigit(c))
                    digitCount++;
            }

            return digitCount == 10;
        }

        private bool IsValidFullName(string fullName)
        {
            if (string.IsNullOrWhiteSpace(fullName))
                return true;

            string[] words = fullName.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length >= 2;
        }

        private ComboBox CreateStatusComboBox()
        {
            ComboBox comboBox = new ComboBox();
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBox.Items.Add("Куплен");
            comboBox.Items.Add("Не куплен");

            comboBox.Tag = new Dictionary<string, object>
            {
                { "Куплен", 1 },
                { "Не куплен", 0 }
            };

            comboBox.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            comboBox.SelectedIndex = 0;
            return comboBox;
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as ComboBox).SelectedItem.ToString() == "Не куплен")
            {
                foreach (Control control in this.Controls)
                {
                    if (control.Name == "buy_date")
                    {
                        DateTimePicker dtp = control as DateTimePicker;
                        dtp.Format = DateTimePickerFormat.Custom;
                        dtp.CustomFormat = " ";
                        dtp.Value = dtp.MinDate;
                        dtp.Enabled = false;
                    }
                    if (control.Name == "fk_id_client")
                    {
                        ComboBox cb = control as ComboBox;
                        cb.SelectedItem = " ";
                        cb.SelectedIndex = -1;
                        cb.Enabled = false;
                    }
                }
            }
            if ((sender as ComboBox).SelectedItem.ToString() == "Куплен")
            {
                foreach (Control control in this.Controls)
                {
                    if (control.Name == "buy_date")
                    {
                        DateTimePicker dtp = control as DateTimePicker;
                        dtp.Format = DateTimePickerFormat.Long;
                        dtp.Value = DateTime.Now;
                        dtp.Enabled = true;
                    }
                    if (control.Name == "fk_id_client")
                    {
                        ComboBox cb = control as ComboBox;
                        cb.SelectedIndex = 0;
                        cb.Enabled = true;
                    }
                }
            }
        }

        private ComboBox CreateAvailableComboBox()
        {
            ComboBox comboBox = new ComboBox();
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBox.Items.Add("Доступен");
            comboBox.Items.Add("Не доступен");

            comboBox.Tag = new Dictionary<string, object>
            {
                { "Доступен", 1 },
                { "Не доступен", 0 }
            };

            comboBox.SelectedIndex = 0;
            return comboBox;
        }

        private ComboBox CreateComboBoxForForeignKey(string fkColumnName)
        {
            ComboBox comboBox = new ComboBox();
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            string referencedTable = GetReferencedTableName(fkColumnName);
            string displayColumn = GetDisplayColumnForTable(referencedTable);
            string idColumn = GetIdColumnForTable(referencedTable);

            string query = $"SELECT {idColumn}, {displayColumn} FROM \"{referencedTable}\" ORDER BY {displayColumn}";

            try
            {
                SQLiteCommand cmd = new SQLiteCommand(query, sqliteConn);
                SQLiteDataReader reader = cmd.ExecuteReader();

                Dictionary<string, object> valueMap = new Dictionary<string, object>();

                while (reader.Read())
                {
                    string displayValue = reader[displayColumn].ToString();
                    object idValue = reader[idColumn];

                    comboBox.Items.Add(displayValue);
                    valueMap[displayValue] = idValue;
                }
                reader.Close();

                comboBox.Tag = valueMap;

                if (comboBox.Items.Count > 0)
                    comboBox.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных для {referencedTable}: {ex.Message}");
            }

            return comboBox;
        }

        private string GetReferencedTableName(string fkColumnName)
        {
            var tableMappings = new Dictionary<string, string>
            {
                {"fk_id_age_rating", "Age_ratings"},
                {"fk_id_hall_type", "Hall_types"},
                {"fk_id_cinema_hall", "Cinema_Halls"},
                {"fk_id_movie", "Movies"},
                {"fk_id_session", "Sessions"},
                {"fk_id_seat", "Seats"},
                {"fk_id_client", "Clients"},
                {"id_movie", "Movies"},
                {"id_genre", "Genres"}
            };

            return tableMappings.ContainsKey(fkColumnName) ? tableMappings[fkColumnName] : fkColumnName.Replace("fk_id_", "");
        }

        private string GetDisplayColumnForTable(string tableName)
        {
            var displayColumns = new Dictionary<string, string>
            {
                {"Age_ratings", "age_rating"},
                {"Hall_types", "hall_type"},
                {"Cinema_Halls", "id_cinema_hall"},
                {"Movies", "name"},
                {"Sessions", "id_session"},
                {"Seats", "id_seat"},
                {"Clients", "client_full_name"},
                {"Genres", "genre"}
            };

            return displayColumns.ContainsKey(tableName) ? displayColumns[tableName] : "id";
        }

        private string GetIdColumnForTable(string tableName)
        {
            var idColumns = new Dictionary<string, string>
            {
                {"Age_ratings", "id_age_rating"},
                {"Hall_types", "id_hall_type"},
                {"Cinema_Halls", "id_cinema_hall"},
                {"Movies", "id_movie"},
                {"Sessions", "id_session"},
                {"Seats", "id_seat"},
                {"Clients", "id_client"},
                {"Genres", "id_genre"},
                {"Tickets", "id_ticket"},
                {"Movie_Genre", "id_movie, id_genre"}
            };

            return idColumns.ContainsKey(tableName) ? idColumns[tableName] : "id";
        }

        private void LoadRecordData()
        {
            string idColumn = GetIdColumnForTable(tableName);
            string query;
            if (tableName == "Movie_Genre")
                query = $"SELECT * FROM \"{tableName}\" WHERE ({idColumn}) = ({recordId[0]}, {recordId[1]})";
            else
                query = $"SELECT * FROM \"{tableName}\" WHERE {idColumn} = {recordId[0]}";

            try
            {
                SQLiteCommand cmd = new SQLiteCommand(query, sqliteConn);
                SQLiteDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    foreach (Control control in this.Controls)
                    {
                        if (control.Name == "id" || control.Name.EndsWith("_id") ||
                            control.Name == "Ok" || control.Name == "Cancel" ||
                            control.Name == "")
                            continue;

                        string fieldName = control.Name;
                        try
                        {
                            object value = reader[fieldName];
                            if (value != DBNull.Value)
                            {
                                SetControlValue(control, value);
                            }
                        }
                        catch
                        {
                        }
                    }
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}\nQuery: {query}", "Ошибка");
            }
        }

        private void SetControlValue(Control control, object value)
        {
            if (control is TextBox textBox)
                textBox.Text = value.ToString();
            else if (control is NumericUpDown numericUpDown)
                numericUpDown.Value = Convert.ToDecimal(value);
            else if (control is DateTimePicker dateTimePicker)
            {
                if (control.Name.Contains("time"))
                {
                    if (DateTime.TryParseExact(value.ToString(), "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dateValue))
                        dateTimePicker.Value = dateValue;
                }
                else
                {
                    if (DateTime.TryParseExact(value.ToString(), "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dateValue))
                        dateTimePicker.Value = dateValue;
                }
            }
            else if (control is CheckBox checkBox)
                checkBox.Checked = Convert.ToBoolean(value);
            else if (control is ComboBox comboBox)
            {
                if (comboBox.Tag is Dictionary<string, object> valueMap)
                {
                    foreach (var item in valueMap)
                    {
                        if (item.Value.ToString() == value.ToString())
                        {
                            comboBox.SelectedItem = item.Key;
                            break;
                        }
                    }
                }
            }
            else if (control is MaskedTextBox maskedTextBox)
            {
                maskedTextBox.Text = value.ToString();
            }
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            if (!ValidateAllFields())
                return;

            if (tableName == "Sessions" && !ValidateSessionConflict())
                return;

            bool success = false;
            try
            {
                if (isInsForm)
                {
                    success = InsertRecord();
                }
                else
                {
                    success = UpdateRecord();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Неожиданная ошибка: {ex.Message}", "Ошибка");
            }

            if (success)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void HandleUniqueConstraintError(string errorMessage)
        {
            string userMessage;

            if (errorMessage.Contains("Seats.fk_id_cinema_hall"))
            {
                userMessage = "Место с такими параметрами (зал, ряд, место) уже существует!";
            }
            else if (errorMessage.Contains("Sessions.fk_id_cinema_hall"))
            {
                userMessage = "Сеанс с такими параметрами (зал, дата, время) уже существует!";
            }
            else if (errorMessage.Contains("Clients.phone"))
            {
                userMessage = "Клиент с таким телефоном уже существует!";
            }
            else if (errorMessage.Contains("Clients.email"))
            {
                userMessage = "Клиент с таким email уже существует!";
            }
            else if (errorMessage.Contains("Age_ratings.age_rating"))
            {
                userMessage = "Возрастной рейтинг с таким названием уже существует!";
            }
            else if (errorMessage.Contains("Hall_types.hall_type"))
            {
                userMessage = "Тип зала с таким названием уже существует!";
            }
            else if (errorMessage.Contains("Genres.genre"))
            {
                userMessage = "Жанр с таким названием уже существует!";
            }
            else if (errorMessage.Contains("Movie_Genre"))
            {
                userMessage = "Связь фильма с жанром уже существует!";
            }
            else if (errorMessage.Contains("Tickets.fk_id_session"))
            {
                userMessage = "Билет на это место в данном сеансе уже существует!";
            }
            else
            {
                userMessage = "Запись с такими данными уже существует в базе!";
            }

            MessageBox.Show(userMessage, "Ошибка уникальности", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private bool ValidateAllFields()
        {
            if (!ValidateFullName())
                return false;

            if (!ValidateEmail())
                return false;

            if (!ValidateRequiredFields())
                return false;

            return true;
        }

        private bool ValidateFullName()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox && control.Name == "client_full_name")
                {
                    string fullName = textBox.Text.Trim();

                    if (!IsValidFullName(fullName))
                    {
                        MessageBox.Show("ФИО должно содержать минимум 2 слова",
                            "Некорректное ФИО",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        textBox.Focus();
                        return false;
                    }
                    break;
                }
            }
            return true;
        }

        private bool ValidateEmail()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox && control.Name == "email")
                {
                    string email = textBox.Text.Trim();

                    if (!string.IsNullOrEmpty(email) && !IsValidEmail(email))
                    {
                        MessageBox.Show("Введите корректный email адрес или оставьте поле пустым",
                            "Некорректный email",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        textBox.Focus();
                        return false;
                    }
                    break;
                }
            }
            return true;
        }

        private bool ValidateRequiredFields()
        {
            foreach (DataRow column in schemaTable.Rows)
            {
                string columnName = column["name"].ToString();
                bool isNullable = Convert.ToInt32(column["notnull"]) == 0;

                if (Convert.ToInt32(column["pk"]) == 1 && tableName != "Movie_Genre")
                    continue;

                if (!isNullable)
                {
                    Control inputControl = null;
                    foreach (Control control in this.Controls)
                    {
                        if (control.Name == columnName)
                        {
                            inputControl = control;
                            break;
                        }
                    }

                    if (inputControl != null)
                    {
                        string value = GetControlValue(inputControl);
                        if (string.IsNullOrEmpty(value) || value == "NULL" || value == "''")
                        {
                            MessageBox.Show($"Поле '{GetDisplayName(columnName)}' обязательно для заполнения",
                                "Обязательное поле",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                            inputControl.Focus();
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        private bool InsertRecord()
        {
            if (tableName == "Seats" && !checkSeatsTable()) return false;

            try
            {
                List<string> columns = new List<string>();
                List<string> values = new List<string>();

                foreach (Control control in this.Controls)
                {
                    if (control is Label || control is Button)
                        continue;

                    string columnName = control.Name;
                    string value = GetControlValue(control);

                    if (!string.IsNullOrEmpty(value) && value != "NULL")
                    {
                        columns.Add($"\"{columnName}\"");
                        values.Add(value);
                    }
                }

                if (columns.Count == 0)
                {
                    MessageBox.Show("Нет данных для сохранения");
                    return false;
                }

                string columnsStr = string.Join(", ", columns);
                string valuesStr = string.Join(", ", values);

                string query = $"INSERT INTO \"{tableName}\" ({columnsStr}) VALUES ({valuesStr})";

                SQLiteCommand cmd = new SQLiteCommand(query, sqliteConn);
                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Запись успешно добавлена!", "Успех");
                    return true;
                }
                else
                {
                    MessageBox.Show("Не удалось добавить запись", "Ошибка");
                    return false;
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UNIQUE constraint failed") || ex.Message.Contains("constraint failed"))
                {
                    HandleUniqueConstraintError(ex.Message);
                }
                else
                {
                    MessageBox.Show($"Ошибка при добавлении записи: {ex.Message}", "Ошибка");
                }
                return false;
            }
        }

        private bool UpdateRecord()
        {
            if (tableName == "Seats" && !checkSeatsTable()) return false;
            try
            {
                List<string> setClauses = new List<string>();

                foreach (Control control in this.Controls)
                {
                    if (control is Label || control is Button)
                        continue;

                    string columnName = control.Name;
                    string value = GetControlValue(control);

                    if (!string.IsNullOrEmpty(value))
                    {
                        setClauses.Add($"\"{columnName}\" = {value}");
                    }
                }

                if (setClauses.Count == 0)
                {
                    MessageBox.Show("Нет данных для обновления");
                    return false;
                }

                string idColumn = GetIdColumnForTable(tableName);
                string setClause = string.Join(", ", setClauses);
                string query;
                if (tableName == "Movie_Genre")
                    query = $"UPDATE \"{tableName}\" SET {setClause} WHERE ({idColumn}) = ({recordId[0]}, {recordId[1]})";
                else
                    query = $"UPDATE  \"{tableName}\" SET {setClause} WHERE {idColumn} = {recordId[0]}";

                SQLiteCommand cmd = new SQLiteCommand(query, sqliteConn);
                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Запись успешно обновлена!", "Успех");
                    return true;
                }
                else
                {
                    MessageBox.Show("Не удалось обновить запись", "Ошибка");
                    return false;
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UNIQUE constraint failed") || ex.Message.Contains("constraint failed"))
                {
                    HandleUniqueConstraintError(ex.Message);
                }
                else
                {
                    MessageBox.Show($"Ошибка при обновлении записи: {ex.Message}", "Ошибка");
                }
                return false;
            }
        }

        private string GetControlValue(Control control)
        {
            if (control is TextBox textBox)
            {
                string text = textBox.Text.Trim();

                if (control.Name == "email")
                {
                    if (!string.IsNullOrEmpty(text) && !IsValidEmail(text))
                    {
                        return "''";
                    }
                }

                if (string.IsNullOrEmpty(text))
                {
                    return "NULL";
                }

                return $"'{text.Replace("'", "''")}'";
            }
            else if (control is NumericUpDown numericUpDown)
            {
                return numericUpDown.Value.ToString(CultureInfo.InvariantCulture);
            }
            else if (control is DateTimePicker dateTimePicker)
            {
                if (control.Name.Contains("time"))
                    return $"'{dateTimePicker.Value:HH:mm}'";
                else if (dateTimePicker.Value != dateTimePicker.MinDate)
                    return $"'{dateTimePicker.Value:yyyy-MM-dd}'";
                else return "NULL";
            }
            else if (control is CheckBox checkBox)
            {
                return checkBox.Checked ? "1" : "0";
            }
            else if (control is ComboBox comboBox)
            {
                if (comboBox.Tag is Dictionary<string, object> valueMap && comboBox.SelectedItem != null)
                {
                    string selectedText = comboBox.SelectedItem.ToString();
                    if (valueMap.ContainsKey(selectedText))
                    {
                        return valueMap[selectedText].ToString();
                    }
                }
                return "NULL";
            }
            else if (control is MaskedTextBox maskedTextBox)
            {
                string phone = maskedTextBox.Text.Trim();

                if (string.IsNullOrEmpty(phone) || !IsPhoneComplete(phone))
                {
                    return "''";
                }

                return $"'{phone.Replace("'", "''")}'";
            }
            else
            {
                return "NULL";
            }
        }

        bool checkSeatsTable()
        {
            int seat = -1;
            int row = -1;
            int hall_id = -1;

            int row_n;
            int seat_n;
            foreach (Control control in Controls)
            {
                if (control.Name == "seat_in_row" && control is NumericUpDown nud)
                    seat = (int)nud.Value;
                if (control.Name == "row" && control is NumericUpDown nud2)
                    row = (int)nud2.Value;
                if (control.Name == "fk_id_cinema_hall" && control is ComboBox cb)
                {
                    if (cb.SelectedItem != null && cb.Tag is Dictionary<string, object> valueMap)
                    {
                        string selectedText = cb.SelectedItem.ToString();
                        if (valueMap.ContainsKey(selectedText))
                        {
                            hall_id = Convert.ToInt32(valueMap[selectedText]);
                        }
                    }
                }
            }
            if (seat == -1 || row == -1 || hall_id == -1) return false;

            string query = $"SELECT seat_number_in_row, row_number FROM \"Cinema_Halls\" WHERE id_cinema_hall == {hall_id}";

            try
            {
                SQLiteCommand cmd = new SQLiteCommand(query, sqliteConn);
                SQLiteDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    row_n = int.Parse(reader["row_number"].ToString());
                    seat_n = int.Parse(reader["seat_number_in_row"].ToString());
                }
                else return false;
                reader.Close();

                if (seat > seat_n)
                {
                    MessageBox.Show($"Номер места больше максимального {seat_n} для зала {hall_id}");
                    return false;
                }
                if (row > row_n)
                {
                    MessageBox.Show($"Номер ряда больше максимального {row_n} для зала {hall_id}");
                    return false;
                }
            }
            catch
            {
            }

            return true;
        }

        private bool CheckSessionConflict(DateTime date, TimeSpan time, int hallId, int? excludeSessionId = null)
        {
            string dateStr = date.ToString("yyyy-MM-dd");
            string timeStr = time.ToString(@"hh\:mm");

            string query = @"SELECT COUNT(*) FROM Sessions 
                    WHERE date_session = @date 
                    AND start_time = @time 
                    AND fk_id_cinema_hall = @hallId";

            if (excludeSessionId.HasValue)
            {
                query += " AND id_session != @excludeId";
            }

            try
            {
                SQLiteCommand cmd = new SQLiteCommand(query, sqliteConn);
                cmd.Parameters.AddWithValue("@date", dateStr);
                cmd.Parameters.AddWithValue("@time", timeStr);
                cmd.Parameters.AddWithValue("@hallId", hallId);

                if (excludeSessionId.HasValue)
                {
                    cmd.Parameters.AddWithValue("@excludeId", excludeSessionId.Value);
                }

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка проверки конфликта сеансов: {ex.Message}");
                return false;
            }
        }

        private bool ValidateSessionConflict()
        {
            DateTime sessionDate = DateTime.MinValue;
            TimeSpan sessionTime = TimeSpan.Zero;
            int hallId = -1;

            foreach (Control control in this.Controls)
            {
                if (control is DateTimePicker dtp && control.Name == "date_session")
                {
                    sessionDate = dtp.Value.Date;
                }
                else if (control is DateTimePicker timeDtp && control.Name == "start_time")
                {
                    sessionTime = timeDtp.Value.TimeOfDay;
                }
                else if (control is ComboBox cb && control.Name == "fk_id_cinema_hall")
                {
                    if (cb.SelectedItem != null && cb.Tag is Dictionary<string, object> valueMap)
                    {
                        string selectedText = cb.SelectedItem.ToString();
                        if (valueMap.ContainsKey(selectedText))
                        {
                            hallId = Convert.ToInt32(valueMap[selectedText]);
                        }
                    }
                }
            }

            if (sessionDate == DateTime.MinValue || sessionTime == TimeSpan.Zero || hallId == -1)
            {
                MessageBox.Show("Не удалось получить данные сеанса для проверки");
                return false;
            }

            int? excludeId = null;
            if (!isInsForm && recordId != null && recordId.Length > 0)
            {
                excludeId = recordId[0];
            }

            if (CheckSessionConflict(sessionDate, sessionTime, hallId, excludeId))
            {
                MessageBox.Show("В выбранном зале уже есть сеанс на это же время и дату!\n" +
                               "Пожалуйста, выберите другое время, дату или зал.",
                               "Конфликт сеансов",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}