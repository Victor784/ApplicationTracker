using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;

namespace AppTrackVSProj
{
    internal class Repository
    {
        private readonly SQLiteConnection _database;

        public Repository(string databasePath)
        {
            _database = new SQLiteConnection(databasePath);
            _database.CreateTable<SentApplication>();
        }

        public void InsertItem(SentApplication item)
        {
            _database.Insert(item);
        }

        public void UpdateItem(SentApplication newItem) 
        {
            //Console.WriteLine("Implementation needed");
            _database.Update(newItem);
        }

        public void DeleteItem(string itemToBeDeletedId) 
        {
            _database.Delete<SentApplication>(itemToBeDeletedId);
        }
        public List<SentApplication> GetAllItems()
        {
            return _database.Table<SentApplication>().ToList();
        }
    }
    partial class Form1
    {
        private Repository repo = new Repository(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "localstorage", "localstorage.db"));
    }


}
