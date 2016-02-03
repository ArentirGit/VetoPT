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
        string ChaineBd;
        OleDbConnection dbCon;

        public DataBaseManagement(string nameDB)
        {
            nameDataBase = nameDB;
            ChaineBd = "Provider=SQLOLEDB;Data Source=INFO-SIMPLET;Initial Catalog=" + nameDataBase + ";Uid=ETD; Pwd=ETD";
            dbCon = new OleDbConnection(ChaineBd);
        }
        public List<Animal> SearchAnimals(string name)
        {
            #region Accès sécurisé
            string sql = "Select Code_Animal, Nom_Animal, Poids_Animal FROM Animal "
                       + " WHERE Nom_Animal Like ?  ORDER BY Nom_Animal";
            nameDataBase = "nom";       
            
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

        public void InsertAnimal(string name,int weight){
            string insert = "INSERT INTO Animal Values (?,?)";
            dbCon.Open();
            OleDbCommand cmd = new OleDbCommand(insert, dbCon);
            cmd.Parameters.Add("Nom", OleDbType.VarChar).Value = name;
            cmd.Parameters.Add("Poids", OleDbType.Integer).Value = weight;
            cmd.ExecuteNonQuery();
            dbCon.Close();
        }

        public void UpdateAnimal(int weight,int code){
            string update = "UPDATE Animal SET Poids_Animal = ? WHERE Code_Animal = ?";
            dbCon.Open();            
            OleDbCommand cmd = new OleDbCommand(update, dbCon);
            cmd.Parameters.Add("Nom", OleDbType.Integer).Value = weight;
            cmd.Parameters.Add("Code", OleDbType.Integer).Value = code;
            dbCon.Close();
        }

        public void DeleteAnimal(int code)
        {
            string delete = "DELETE FROM Abonné WHERE Code_Abonné = ?";
            dbCon.Open();
            OleDbCommand cmd = new OleDbCommand(delete, dbCon);
            cmd.Parameters.Add("Code", OleDbType.Integer).Value = code;
            dbCon.Close();
        }


    }
}
