using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public void UpdateAnimal(string name, string weight, int id){
            string update = "UPDATE Animal SET nom = ? ,poids = ?  WHERE id = ?";
            dbCon.Open();            
            OleDbCommand cmd = new OleDbCommand(update, dbCon);
            cmd.Parameters.Add("Nom", OleDbType.VarChar).Value = name;
            cmd.Parameters.Add("Poids", OleDbType.VarChar).Value = weight;
            cmd.Parameters.Add("Code", OleDbType.Integer).Value = id;
            cmd.ExecuteNonQuery();
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

        public void insertReminder(string date, string intitule)
        {
            string insert = "INSERT INTO Rappel Values (1,?,?)";
            dbCon.Open();
            OleDbCommand cmd = new OleDbCommand(insert, dbCon);
            cmd.Parameters.Add("Date", OleDbType.VarChar).Value = date;
            cmd.Parameters.Add("Intitule", OleDbType.VarChar).Value = intitule;
            cmd.ExecuteNonQuery();
            dbCon.Close();
        }

        public void updateReminder(int code_reminder, string date, string intitule)
        {
            string update = "UPDATE Rappel SET date = ?, intitule = ? WHERE id = ?";
            dbCon.Open();
            OleDbCommand cmd = new OleDbCommand(update, dbCon);
            cmd.Parameters.Add("Date", OleDbType.VarChar).Value = date;
            cmd.Parameters.Add("Intitule", OleDbType.VarChar).Value = intitule;
            cmd.Parameters.Add("id", OleDbType.Integer).Value = code_reminder;
            cmd.ExecuteNonQuery();
            dbCon.Close();
        }

        public void deleteReminder(int code_reminder)
        {
            string delete = "DELETE FROM Rappel WHERE id = ?";
            dbCon.Open();
            OleDbCommand cmd = new OleDbCommand(delete, dbCon);
            cmd.Parameters.Add("id", OleDbType.Integer).Value = code_reminder;
            cmd.ExecuteNonQuery();
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

        public void insertBreed(string breed_name)
        {
            string insert = "INSERT INTO Race Values (?)";
            dbCon.Open();
            OleDbCommand cmd = new OleDbCommand(insert, dbCon);
            cmd.Parameters.Add("Nom Race", OleDbType.VarChar).Value = breed_name;
            cmd.ExecuteNonQuery();
            dbCon.Close();
        }

        public List<string> getAnimals()
        {
            string get = "SELECT nom FROM Animal";
            dbCon.Open();
            OleDbCommand cmd = new OleDbCommand(get, dbCon);
            OleDbDataReader reader = cmd.ExecuteReader();
            List<string> animals = new List<string>();
            while (reader.Read())
            {
                animals.Add(reader.GetString(0));
            }
            reader.Close();
            dbCon.Close();
            return animals;
        }

        public List<string> getSpecies()
        {
            string get = "SELECT intitule FROM Espece";
            dbCon.Open();
            OleDbCommand cmd = new OleDbCommand(get, dbCon);
            OleDbDataReader reader = cmd.ExecuteReader();
            List<string> species = new List<string>();
            while (reader.Read()){
                species.Add(reader.GetString(0));
            }
            reader.Close();
            dbCon.Close();
            return species;
        }

        public List<string> getBreeds()
        {
            string get = "SELECT intitule FROM Race";
            dbCon.Open();
            OleDbCommand cmd = new OleDbCommand(get, dbCon);
            OleDbDataReader reader = cmd.ExecuteReader();
            List<string> breeds = new List<string>();
            while (reader.Read()){
                breeds.Add(reader.GetString(0));
            }
            reader.Close();
            dbCon.Close();
            return breeds;
        }

        public List<string> getPeople()
        {
            string get = "SELECT nom,prenom FROM Personne";
            dbCon.Open();
            OleDbCommand cmd = new OleDbCommand(get, dbCon);
            OleDbDataReader reader = cmd.ExecuteReader();
            List<string> people = new List<string>();
            while (reader.Read()){
                people.Add(reader.GetString(0) + ":" + reader.GetString(1));
            }
            reader.Close();
            dbCon.Close();
            return people;
        }

        public List<string> getReminders()
        {
            string get = "SELECT * FROM Rappel";   
            dbCon.Open();
            OleDbCommand cmd = new OleDbCommand(get, dbCon);
            OleDbDataReader reader = cmd.ExecuteReader();
            List<string> reminders = new List<string>();
            while (reader.Read()){
                reminders.Add(reader.GetInt32(0) + ":" + reader.GetString(1) + ":" + reader.GetString(2));
            }
            reader.Close();
            dbCon.Close();
            return reminders;
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
            cmd.Parameters.Add("Email", OleDbType.VarChar).Value = mail;
            cmd.ExecuteNonQuery();
            dbCon.Close();
        }

        public void modifyClient(int code, string city, string adress, string mail)
        {
            string update = "UPDATE Personne SET ville= ?, adresse= ?, email= ? WHERE id = ?";
            dbCon.Open();
            OleDbCommand cmd = new OleDbCommand(update, dbCon);
            cmd.Parameters.Add("Ville", OleDbType.VarChar).Value = city;
            cmd.Parameters.Add("Adresse", OleDbType.VarChar).Value = adress;
            cmd.Parameters.Add("Mail", OleDbType.VarChar).Value = mail;
            cmd.Parameters.Add("Code", OleDbType.Integer).Value = code;
            cmd.ExecuteNonQuery();
            dbCon.Close();
        }

        public void deleteClient(int code)
        {
            string delete = "DELETE FROM Personne WHERE id = ?";
            dbCon.Open();
            OleDbCommand cmd = new OleDbCommand(delete, dbCon);
            cmd.Parameters.Add("Code client", OleDbType.Integer).Value = code;
            cmd.ExecuteNonQuery();
            dbCon.Close();
        }

        public List<string> DisplayClients()
        {
            string display = "SELECT id,nom,prenom,ville,adresse,email from Personne";
            dbCon.Open();
            OleDbCommand cmd = new OleDbCommand(display, dbCon);
            OleDbDataReader reader = cmd.ExecuteReader();
            List<string> clients = new List<string>();
            while (reader.Read())
            {
                clients.Add(reader.GetInt32(0) + ":" + reader.GetString(1) + ":" + reader.GetString(2) + ":" + reader.GetString(3) + ":" + reader.GetString(4) + ":" + reader.GetString(5));
            }
            reader.Close();
            dbCon.Close();
            return clients;
        }

        public string detailsClient(int code)
        {
            string details = "SELECT id,nom,prenom,ville,adresse,email from Personne where id=?";
            dbCon.Open();
            OleDbCommand cmd = new OleDbCommand(details, dbCon);
            cmd.Parameters.Add("Code client", OleDbType.Integer).Value = code;
            cmd.ExecuteNonQuery();
            OleDbDataReader reader = cmd.ExecuteReader();
            reader.Read();
            string client = reader.GetInt32(0) + ":" + reader.GetString(1) + ":" + reader.GetString(2) + ":" + reader.GetString(3) + ":" + reader.GetString(4) + ":" + reader.GetString(5);
            reader.Close();
            dbCon.Close();
            return client;
        }

        public void addAppointement(string date, string objet, int codeClient, int codeAnimal)
        {
            string insert = "INSERT INTO Rendez_Vous JOIN Animal ON Rendez_Vous.id = Animal.id JOIN Personne ON Personne.id = Animal.id Values (?,?) Where Personne.id=? and Animal.id =?";
            dbCon.Open();
            OleDbCommand cmd = new OleDbCommand(insert, dbCon);
            cmd.Parameters.Add("Date", OleDbType.VarChar).Value = date;
            cmd.Parameters.Add("Objet", OleDbType.VarChar).Value = objet;
            cmd.Parameters.Add("idClient", OleDbType.Integer).Value = codeClient;
            cmd.Parameters.Add("idAnimal", OleDbType.Integer).Value = codeAnimal;
            cmd.ExecuteNonQuery();
            dbCon.Close();
        }

        public List<string> getAnimalsClient(int codeClient)
        {
            string display = "SELECT * from Personne Join Animal.id=Personne.id Where Personne.id = ?";
            dbCon.Open();
            OleDbCommand cmd = new OleDbCommand(display, dbCon);
            cmd.Parameters.Add("idClient", OleDbType.Integer).Value = codeClient;
            cmd.ExecuteNonQuery();
            OleDbDataReader reader = cmd.ExecuteReader();
            List<string> animals = new List<string>();
            while (reader.Read())
            {
                animals.Add(reader.GetInt32(0) + ":" + reader.GetString(1));
            }
            reader.Close();
            dbCon.Close();
            return animals;
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
