using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryAppPrototype
{
    public partial class InventoryApp : Form
    {
        
        //Reference to the Database being used in the App.
        private Database db;
        
        private MainScreen mainScreen1;
        private AddItem addItem1;
        private FindScreen findScreen1;
        private RemoveItem removeItem1;
        private EditScreen editScreen1;
        private EditItem editItem1;

        public InventoryApp()
        {
            InitializeComponent();

            //Create Main Screen Page, Child Object.
            this.mainScreen1 = new MainScreen(this);
            this.Controls.Add(mainScreen1);

            //Create Add Item Page, Child Object.
            this.addItem1 = new AddItem(this);
            this.Controls.Add(addItem1);

            //Create Find Screen Page, Child Object.
            this.findScreen1 = new FindScreen(this);
            this.Controls.Add(findScreen1);

            //Create Remove Item Page, Child Object.
            this.removeItem1 = new RemoveItem(this);
            this.Controls.Add(removeItem1);

            //Creare Edit Screen Page, Child Object.
            this.editScreen1 = new EditScreen(this);
            this.Controls.Add(editScreen1);

            //Create Edit Item Page, Child Object.
            this.editItem1 = new EditItem(this);
            this.Controls.Add(editItem1);

            //Hide each Child Pages expect the Main Screen Page.
            addItem1.Hide();
            findScreen1.Hide();
            removeItem1.Hide();
            editScreen1.Hide();
            editItem1.Hide();

            //Is The App Connected to the MySQL Server.
            mainScreen1.testConnection();
        }

        public void createDB()
        {
            //MySQL Server Login Credentials.
            string host = "";
            int port = 0;
            string database = "";
            string username = "";
            string password = "";

            //Log into the MySQL Server.
            this.db = new Database(this, host, port, database, username, password);
        }

        public void dbSet(int page)
        {
            db.currentPage(page);
        }

        public bool getState()
        {
            //What is the state of the MySQL servers connection.
            if (db.getState() == true)
            {
                //This app is connected to the MySQL Server.
                return true;
            }
            else
            {
                //This app is disconnected from the MySQL Server.
                return false;
            }
        }

        public void showMainPage(int pageNumber)
        {
            if (pageNumber == 0)
            {
                //Returning from the Add Item Page.
                addItem1.Hide();
            }
            else if(pageNumber == 1)
            {
                //Returning from the Find Screen Page.
                findScreen1.Hide();
            }
            else if(pageNumber == 2)
            {
                editScreen1.Hide();
            }
            else
            {
                editItem1.Hide();
            }

            //Display the Main Screen Page.
            mainScreen1.BringToFront();
            mainScreen1.Show();
        }

        public void showFindPage(int pageNumber)
        {
            if (pageNumber == 0)
            {
                //Leaving the Main Screen Page.
                mainScreen1.Hide();
            }
            else
            {
                //Returning from the Remove Item Page.
                removeItem1.Hide();
            }

            db.currentPage(1);

            //Pull the Table from the Database Selected.
            db.getTable();

            //Display the Find Screen Page.
            findScreen1.BringToFront();
            findScreen1.Show();
        }

        public void showAddPage()
        {
            //Leaving from the Main Screen Page.
            mainScreen1.Hide();

            db.currentPage(0);
            db.getColumns();

            addItem1.setPage(true);

            //Display the Add Item Page.
            addItem1.BringToFront();
            addItem1.Show();
        }

        public void showRemovePage()
        {
            //Leaving from the Find Screen Page.
            findScreen1.Hide();

            //Display the Remove Item Page.
            removeItem1.BringToFront();
            removeItem1.Show();
        }

        public void showEditScreenPage()
        {
            //Leaving from the Main Screen Page.
            mainScreen1.Hide();

            //Display the Add Item Page.
            editScreen1.BringToFront();
            editScreen1.Show();
        }

        public void showEditItemPage(string item)
        {
            editScreen1.Hide();
            editItem1.updateInputs(item);
            editItem1.Show();
        }

        //Let the Application Handle the Database Interaction.
        public void addItem(string columns, string Items)
        {
            db.addEntry(columns, Items);
        }

        public void removeItem(string Item)
        {
            db.removeEntry(Item);
        }

        public string getEntry(string item)
        {
            return db.getEntry(item);
        }

        public void updateEntry(string item, string newItem)
        {
            db.updateEntry(item, newItem);
        }

        public void clearList()
        {
            findScreen1.clearList();
        }

        public void setColumn(string item)
        {
            findScreen1.setColumn(item);
        }

        public void setItem(string item)
        {
            findScreen1.setItem(item);
        }

        public void addSubItem(string item)
        {
            findScreen1.addSubItem(item);
        }

        public void createItem()
        {
            findScreen1.createItem();
        }

        public void createInput(string item)
        {
            addItem1.createInput(item);
        }
    }
}
