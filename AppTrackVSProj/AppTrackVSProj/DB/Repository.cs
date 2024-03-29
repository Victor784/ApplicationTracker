﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;
using AppTrackVSProj.DB.Model;

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
    partial class MainForm
    {
        private Repository repo = new Repository(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DB","localstorage", "localstorage.db"));
    }

    /*
      if(dbData.Count < 25 ) { progressBar.Maximum = 25; }
            else if (dbData.Count >= 25 && dbData.Count < 50) { progressBar.Maximum = 50; } 
            else if (dbData.Count >= 50 && dbData.Count < 100) { progressBar.Maximum = 100; }
            else if (dbData.Count >= 100 && dbData.Count < 200) { progressBar.Maximum = 200; }
            else if (dbData.Count >= 200 && dbData.Count < 250) { progressBar.Maximum = 250; }
            else if (dbData.Count >= 250 && dbData.Count < 500) { progressBar.Maximum = 500; }
            else if (dbData.Count >= 500 && dbData.Count < 750) { progressBar.Maximum = 750; }
            else if (dbData.Count >= 750 && dbData.Count < 1000) { progressBar.Maximum = 1000; }

     */
   
    
}
