using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace InventoryAppPrototype
{
    class Database
    {
        private MySqlConnection connection;
        private InventoryApp app;

        private String TableName;
        private bool isConnected;
        private int page;

        public Database(InventoryApp app, 
            string host, int port, string database, string username, string password)
        {
            //Select a table from the Database selected to use.
            this.TableName = "test_table";

            //Format the MySQL Server Login Credentials.
            String conString = "Server=" + host + ";Database=" + database
                + ";port=" + port + ";User Id=" + username + ";password=" + password;

            //Create a connection the selected Database from the MySQL Server. 
            this.connection = new MySqlConnection(conString);

            //Reference to a page that the database needs for creating a List View.
            this.app = app;

            try
            {
                //Starting the Connection.
                connection.Open();

                //The Connection to the MySQL server is a success. 
                this.isConnected = true;

                //Ending the Connection Temporary.
                connection.Close();

            }catch(MySqlException){
                //The connection to the MySQL Server was a failure.
                this.isConnected = false;
            }

        }

        public void addEntry(string columns, string items)
        {
            //Starting the Connection.
            connection.Open();

            //SQL Command for creating a new row in the Table.
            string query = "insert into " + TableName + " (" + columns + ") values (" + items + ");";

            //Old SQL Command for creating a new row in the Table.
            //string query = "insert into " + TableName  + " (product_name,product_desc) values (\""+ item + "\",\"name\");";

            //Send the Command to the set Database Selected. 
            MySqlCommand command = new MySqlCommand(query, connection);

            //Run the command to add the new row to the table.
            command.ExecuteNonQuery();

            //Ending the Connection Temporary.
            connection.Close();
        }

        public string getEntry(string item)
        {
            //Starting the Connection.
            connection.Open();

            //SQL Command for selecting a row from the Table.
            string query = "select * from " + TableName + " where product_name=\"" + item + "\";";

            //Send the Command to the set Database Selected. 
            MySqlCommand command = new MySqlCommand(query, this.connection);

            //Run the command but return the results.
            MySqlDataReader reader = command.ExecuteReader();

            reader.Read();
            var dataRetrieve = reader["product_name"].ToString();

            //Ending the Connection Temporary.
            connection.Close();

            return dataRetrieve;
        }

        public void currentPage(int page)
        {
            this.page = page; 
        }

        public void updateEntry(string item, string newItem)
        {
            //Starting the Connection.
            connection.Open();

            //var itemProperty = "";

            //SQL Command for updating a row from the Table.
            //string query = "update " + TableName + " set "+ itemProperty 
            //    + "=\"" + newItem + "\"  where product_name=\"" + item + "\";";

            // " where " 
            // product_name + "=\"" + item + "\""
            // "," + product_name + "=\"" + item + "\""
            // ";"

            //SQL Command for updating a row from the Table.
            string query = "update " + TableName + " set product_name=\"" + newItem 
                + "\"  where product_name=\"" + item + "\";";

            //Send the Command to the set Database Selected. 
            MySqlCommand command = new MySqlCommand(query, this.connection);

            //Run the command to remove the row from the table.
            command.ExecuteNonQuery();

            //Ending the Connection Temporary.
            connection.Close();
        }

        public void removeEntry(string item)
        {
            //Starting the Connection.
            connection.Open();

            //SQL Command for removing a row from the Table.
            string query = "delete from " + TableName + " where product_name=\"" + item + "\";";

            //Send the Command to the set Database Selected. 
            MySqlCommand command = new MySqlCommand(query, this.connection);

            //Run the command to remove the row from the table.
            command.ExecuteNonQuery();

            //Ending the Connection Temporary.
            connection.Close();
        }

        public void getColumns()
        {
            //Starting the Connection.
            connection.Open();

            //Clear the List View to the most up to date display of the Database.
            app.clearList();

            String query = "describe " + TableName + ";";

            MySqlCommand command = new MySqlCommand(query, this.connection);

            MySqlDataReader reader = command.ExecuteReader();

            if (this.page == 0)
            {
                while (reader.Read())
                {
                    //Creating and displaying the columns from the database to the app. *Still in Progress of dynamic columns*
                    app.createInput(reader.GetValue(0).ToString());
                }
            }
            else
            {
                while (reader.Read())
                {
                    //Creating and displaying the columns from the database to the app. *Still in Progress of dynamic columns*
                    app.setColumn(reader.GetValue(0).ToString());
                }
            }


            reader.Close();

            //Ending the Connection Temporary.
            connection.Close();
        }

        public void getTable()
        {
            getColumns();

            //Starting the Connection.
            connection.Open();

            //SQL Command for grabbing everything from the selected Table.
            String query = "select * from " + TableName + ";";

            //Send the Command to the set Database Selected. 
            MySqlCommand command = new MySqlCommand(query, this.connection);

            //Run the command but return the results.
            MySqlDataReader reader = command.ExecuteReader();

            //Reads Row by Row.
            while (reader.Read())
            {
                //Creating and Displaying the row from the database to the app. *Still in Progress of dynamic rows*
                app.setItem(reader.GetValue(0).ToString());
                for (int i = 1; i < reader.FieldCount; i++)
                {
                    app.addSubItem(reader.GetValue(i).ToString());
                }
                app.createItem();
            }

            //Ending the Connection Temporary.
            connection.Close();
        }

        public bool getState()
        {
            //Can this Database be accessed.
            return isConnected;
        }

    }
}
