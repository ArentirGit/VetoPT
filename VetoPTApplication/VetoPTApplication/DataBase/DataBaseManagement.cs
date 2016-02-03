using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetoPTApplication.DataBase
{
    class DataBaseManagement
    {
        string nameDataBase;

        public DataBaseManagement(string nameDB)
        {
            nameDataBase = nameDB;
        }
        public List<Animal> SearchAnimals(string name)
        {
            #region Accès sécurisé
            string sql = "Select Code_Animal, Nom_Animal, Poids_Animal FROM Animal "
                       + " WHERE Nom_Animal Like ?  ORDER BY Nom_Animal";
            nameDataBase = "nom";
            OleDbConnection dbCon;
            string ChaineBd = "Provider=SQLOLEDB;Data Source=INFO-SIMPLET;Initial Catalog=" + nameDataBase + ";Uid=ETD; Pwd=ETD";
            dbCon = new OleDbConnection(ChaineBd);
            dbCon.Open();
            OleDbCommand cmd = new OleDbCommand(sql, dbCon);
            cmd.Parameters.Add("init", OleDbType.VarChar).Value = name;
            OleDbDataReader reader = cmd.ExecuteReader();
            List<Animal> animals = new List<Animal>();
            while (reader.Read())
            {
                Animal animal = new Animal();
                animal.Code_Animal = reader.GetInt32(0);
                animal.Nom_Animal = reader.GetString(1);
                if (!reader.IsDBNull(2))
                    animal.Poids_Animal = reader.GetInt32(2);
                animals.Add(animal);
            }
            reader.Close();
            dbCon.Close();
            return animals;
            #endregion
        }
    }
}
