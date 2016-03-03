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

        public List<string> DisplayAnimals()
        {
            string display = "SELECT id,nom from Animal";
            dbCon.Open();
            OleDbCommand cmd = new OleDbCommand(display, dbCon);
            OleDbDataReader reader = cmd.ExecuteReader();
            List<string> animals = new List<string>();
            while (reader.Read()){
                animals.Add(reader.GetInt32(0) + ":" + reader.GetString(1));
            }
            reader.Close();
            dbCon.Close();
            return animals;
        }

        public void InsertAnimal(string name,string weight, string birth){
            string insert = "INSERT INTO Animal Values (?,?,?)";
            dbCon.Open();
            OleDbCommand cmd = new OleDbCommand(insert, dbCon);
            cmd.Parameters.Add("Nom", OleDbType.VarChar).Value = name;
            cmd.Parameters.Add("Poids", OleDbType.VarChar).Value = weight;
            cmd.Parameters.Add("Date de naissance", OleDbType.VarChar).Value = birth;
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
            string delete = "DELETE FROM Animal WHERE id = ?";
            dbCon.Open();
            OleDbCommand cmd = new OleDbCommand(delete, dbCon);
            cmd.Parameters.Add("id", OleDbType.Integer).Value = code;
            cmd.ExecuteNonQuery();
            dbCon.Close();
        }

        public void displayAppointment(int code_animal)
        {
            string display = "SELECT date, objet FROM Rendez_Vous "
                            + "JOIN Animal ON Rendez_Vous.id = Animal.id "
                            + "WHERE Animal.id = ?";
            dbCon.Open();
            OleDbCommand cmd = new OleDbCommand(display, dbCon);
            cmd.Parameters.Add("Code", OleDbType.Integer).Value = code_animal;
            dbCon.Close(); 
        }

        public void displayAnimalCare(int code_animal)
        {
            string display = "SELECT nom FROM Traitement "
                            + "JOIN Animal ON Traitement.id = Animal.id "
                            + "WHERE Animal.id = ?";
            dbCon.Open();
            OleDbCommand cmd = new OleDbCommand(display, dbCon);
            cmd.Parameters.Add("Code", OleDbType.Integer).Value = code_animal;
            dbCon.Close();
        }

        public void displayAnimalDetails(int code_animal)
        {
            string display = "SELECT * FROM Animal "
                            + "WHERE Animal.id = ?";
            dbCon.Open();
            OleDbCommand cmd = new OleDbCommand(display, dbCon);
            cmd.Parameters.Add("Code", OleDbType.Integer).Value = code_animal;
            dbCon.Close();
        }

        public void insertAnimalv2(string name, int weight, string owner, string birth_date, string specy, string breed)
        {
            string insert = "INSERT INTO Animal Values (?,?,?);"
                          + "INSERT INTO Race Values (?) "
                           + "JOIN Race on Animal.id = Race.id;"
                          + "INSERT INTO Personne Values (?) "
                           + "JOIN Personne on Personne.id = Animal.id;"
                          + "INSERT INTO Espece Values (?) "
                           + "JOIN Race on Race.id = Espece.id;";
                           
            dbCon.Open();
            OleDbCommand cmd = new OleDbCommand(insert, dbCon);
            cmd.Parameters.Add("Nom", OleDbType.VarChar).Value = name;
            cmd.Parameters.Add("Poids", OleDbType.Integer).Value = weight;
            cmd.Parameters.Add("Date de naissance", OleDbType.VarChar).Value = birth_date;
            cmd.Parameters.Add("Race", OleDbType.VarChar).Value = breed;
            cmd.Parameters.Add("Proprietaire", OleDbType.VarChar).Value = owner;
            cmd.Parameters.Add("Espece", OleDbType.VarChar).Value = specy;
            cmd.ExecuteNonQuery();
            dbCon.Close();
        }

        public void updateAnimalv2(int weight, int code)
        {
            string update = "UPDATE Animal SET Poids_Animal = ? WHERE Code_Animal = ?";
            dbCon.Open();
            OleDbCommand cmd = new OleDbCommand(update, dbCon);
            cmd.Parameters.Add("Nom", OleDbType.Integer).Value = weight;
            cmd.Parameters.Add("Code", OleDbType.Integer).Value = code;
            dbCon.Close();
        }

        public void displayReminders()
        {
            string display = "SELECT * FROM Rappel "
                            + "JOIN Traitement on Traitement.id = Rappel.id "
                            + "JOIN Animal on Animal.id = Traitement.id "
                            + "JOIN Personne on Personne.id = Animal.id";
            dbCon.Open();
            OleDbCommand cmd = new OleDbCommand(display, dbCon);
            dbCon.Close();
        }

        public void insertReminder(string date, string intitule, string code_animal)
        {
            string insert = "INSERT INTO Rappel Values (?,?)"
                            + "JOIN Traitement on Traitement.id = Rappel.id "
                            + "JOIN Animal on Traitement.id = Animal.id "
                            + "WHERE Animal.id = ?";
            dbCon.Open();
            OleDbCommand cmd = new OleDbCommand(insert, dbCon);
            cmd.Parameters.Add("Date Rappel", OleDbType.VarChar).Value = date;
            cmd.Parameters.Add("Intitule", OleDbType.VarChar).Value = intitule;
            cmd.Parameters.Add("Code Animal", OleDbType.VarChar).Value = code_animal;
            cmd.ExecuteNonQuery();
            dbCon.Close();
        }

        public void updateReminder(int code_reminder, string date, string intitule)
        {
            string update = "UPDATE Reminder SET date = ? and Intitule = ? "
                            + "WHERE id = ?";
            dbCon.Open();
            OleDbCommand cmd = new OleDbCommand(update, dbCon);
            cmd.Parameters.Add("Code Rappel", OleDbType.Integer).Value = code_reminder;
            cmd.Parameters.Add("Date", OleDbType.VarChar).Value = date;
            cmd.Parameters.Add("Intitule", OleDbType.VarChar).Value = intitule;
            dbCon.Close();
        }

        public void deleteReminder(int code_reminder)
        {
            string delete = "DELETE FROM Rappel WHERE id = ?";
            dbCon.Open();
            OleDbCommand cmd = new OleDbCommand(delete, dbCon);
            cmd.Parameters.Add("Code Rappel", OleDbType.Integer).Value = code_reminder;
            dbCon.Close();
        }

        public void insertSpecy(string specy_name)
        {
            string insert = "INSERT INTO Espece Values (?)";
            dbCon.Open();
            OleDbCommand cmd = new OleDbCommand(insert, dbCon);
            cmd.Parameters.Add("Nom Espece", OleDbType.VarChar).Value = specy_name;
            cmd.ExecuteNonQuery();
            dbCon.Close();
        }

        public string[] displaySpecies()
        {
            string display = "SELECT intitule FROM Espece";
            dbCon.Open();
            OleDbCommand cmd = new OleDbCommand(display, dbCon);
            OleDbDataReader reader = cmd.ExecuteReader();
            string[] species = new string[20];
            int i = 0;
            while (reader.Read())
            {
                species[i] = reader.GetString(0);
                i++;
            }
            reader.Close();
            dbCon.Close();
            return species;
        }

        public void insertBreed(string breed_name)
        {
            string insert = "INSERT INTO Race Values (?)";
            dbCon.Open();
            OleDbCommand cmd = new OleDbCommand(insert, dbCon);
            cmd.Parameters.Add("Nom Race", OleDbType.VarChar).Value = breed_name;
            cmd.ExecuteNonQuery();
            dbCon.Close();
        }

        //ClientManagement

        public void addClient(string name, string firstname, string city, string adress, string mail)
        {
            string insert = "INSERT INTO Personne Values (?,?,?,?,?)";
            dbCon.Open();
            OleDbCommand cmd = new OleDbCommand(insert, dbCon);
            cmd.Parameters.Add("Nom", OleDbType.VarChar).Value = name;
            cmd.Parameters.Add("Prénom", OleDbType.VarChar).Value = firstname;
            cmd.Parameters.Add("Ville", OleDbType.VarChar).Value = city;
            cmd.Parameters.Add("Adresse", OleDbType.VarChar).Value = adress;
            cmd.Parameters.Add("Mail", OleDbType.VarChar).Value = mail;
            cmd.ExecuteNonQuery();
            dbCon.Close();
        }

        public void modifyClient(string name, string firstname, string city, string adress, string mail)
        {

        }

        public void deleteClient()
        {

        }

        public void displayClients()
        {

        }

        public void addAppointement()
        {

        }

        public void modifyAppointement()
        {

        }

        public void cancelAppointement()
        {

        }

        public void displayAppointements()
        {

        }

    }
}
