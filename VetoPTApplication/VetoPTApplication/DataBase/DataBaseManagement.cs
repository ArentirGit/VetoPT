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

        public void insertUser(string user_rank, string id, string password)
        {
            string insert = "INSERT INTO Personnel Values (?,?,?)";
            dbCon.Open();
            OleDbCommand cmd = new OleDbCommand(insert, dbCon);
            cmd.Parameters.Add("Rang User", OleDbType.VarChar).Value = user_rank;
            cmd.Parameters.Add("Identifiant User", OleDbType.VarChar).Value = id;
            cmd.Parameters.Add("Mot de passe User", OleDbType.VarChar).Value = password;
            cmd.ExecuteNonQuery();
            dbCon.Close();
        }

        public List<string> displayUsers()
        {
            string display = "SELECT * FROM Personnel";
            dbCon.Open();
            OleDbCommand cmd = new OleDbCommand(display, dbCon);
            OleDbDataReader reader = cmd.ExecuteReader();
            List<string> users = new List<string>();
            while (reader.Read())
            {
                users.Add(reader.GetInt32(0) + ":" + reader.GetString(1) + ":" + reader.GetString(2) + ":" + reader.GetString(3));
            }
            reader.Close();
            dbCon.Close();
            return users;
        }

        public void updateUser(string rank, string login, string password, int user_id)
        {
            string update = "UPDATE Personnel SET rank = ?, login = ?, password = ? "
                             + "WHERE id = ?";
            dbCon.Open();
            OleDbCommand cmd = new OleDbCommand(update, dbCon);
            cmd.Parameters.Add("Rang User", OleDbType.VarChar).Value = rank;
            cmd.Parameters.Add("Login User", OleDbType.VarChar).Value = login;
            cmd.Parameters.Add("Password User", OleDbType.VarChar).Value = password;
            cmd.Parameters.Add("ID Personnel", OleDbType.Integer).Value = user_id;
            cmd.ExecuteNonQuery();
            dbCon.Close();
        }

        public void deleteUser(int user_id)
        {
            string delete = "DELETE FROM Personnel WHERE id = ?";
            dbCon.Open();
            OleDbCommand cmd = new OleDbCommand(delete, dbCon);
            cmd.Parameters.Add("ID User", OleDbType.Integer).Value = user_id;
            cmd.ExecuteNonQuery();
            dbCon.Close();
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
            while (reader.Read())
            {
                animals.Add(reader.GetInt32(0) + ":" + reader.GetString(1));
            }
            reader.Close();
            dbCon.Close();
            return animals;
        }

        public void InsertAnimal(string name, string weight, string birth, int person_id, int breed_id)
        {
            string insert = "INSERT INTO Animal Values (?,?,?,?,?)";
            dbCon.Open();
            OleDbCommand cmd = new OleDbCommand(insert, dbCon);
            cmd.Parameters.Add("Nom", OleDbType.VarChar).Value = name;
            cmd.Parameters.Add("Poids", OleDbType.VarChar).Value = weight;
            cmd.Parameters.Add("Date de naissance", OleDbType.VarChar).Value = birth;
            cmd.Parameters.Add("ID personne", OleDbType.Integer).Value = person_id;
            cmd.Parameters.Add("ID race", OleDbType.Integer).Value = breed_id;
            cmd.ExecuteNonQuery();
            dbCon.Close();
        }

        public void UpdateAnimal(string name, string weight, string birth, int person_id, int breed_id, int animal_id)
        {
            string update = "UPDATE Animal SET nom = ?, poids = ?, date_naissance = ?, PersonneID = ?, RaceID = ? "
                             + "WHERE id = ?";
            dbCon.Open();
            OleDbCommand cmd = new OleDbCommand(update, dbCon);
            cmd.Parameters.Add("Nom", OleDbType.VarChar).Value = name;
            cmd.Parameters.Add("Poids", OleDbType.VarChar).Value = weight;
            cmd.Parameters.Add("Date naissance", OleDbType.VarChar).Value = birth;
            cmd.Parameters.Add("ID Personne", OleDbType.Integer).Value = person_id;
            cmd.Parameters.Add("ID Race", OleDbType.Integer).Value = breed_id;
            cmd.Parameters.Add("ID Animal", OleDbType.Integer).Value = animal_id;
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

        public String displayAnimalDetails(int code_animal)
        {
            string display = "SELECT Animal.nom,poids,date_naissance,Personne.nom,Personne.prenom,Espece.intitule,Race.intitule, Personne.id FROM Animal "
                            + "JOIN Personne on Personne.id = Animal.PersonneID "
                            + "JOIN Race on Race.id = Animal.RaceID "
                            + "JOIN Espece on Espece.id = Race.EspeceID "
                            + "WHERE Animal.id = ?";
            dbCon.Open();
            OleDbCommand cmd = new OleDbCommand(display, dbCon);
            cmd.Parameters.Add("Code", OleDbType.Integer).Value = code_animal;
            OleDbDataReader reader = cmd.ExecuteReader();
            String details = "";
            while (reader.Read())
            {
                details += (reader.GetString(0) + ":" + reader.GetString(1)
                    + ":" + reader.GetString(2) + ":" + reader.GetString(3) + ":" + reader.GetString(4)
                    + ":" + reader.GetString(5) + ":" + reader.GetString(6) + ":" + reader.GetInt32(7));
            }
            reader.Close();
            dbCon.Close();
            return details;
        }

        public void insertReminder(string date, string intitule)
        {
            string insert = "INSERT INTO Rappel Values (3,?,?)";
            dbCon.Open();
            OleDbCommand cmd = new OleDbCommand(insert, dbCon);
            cmd.Parameters.Add("Date", OleDbType.VarChar).Value = date;
            cmd.Parameters.Add("Intitule", OleDbType.VarChar).Value = intitule;
            cmd.ExecuteNonQuery();
            dbCon.Close();
        }

        public void updateReminder(int reminder_id, string date, string intitule)
        {
            string update = "UPDATE Rappel SET date = ?, intitule = ? WHERE id = ?";
            dbCon.Open();
            OleDbCommand cmd = new OleDbCommand(update, dbCon);
            cmd.Parameters.Add("Date", OleDbType.VarChar).Value = date;
            cmd.Parameters.Add("Intitule", OleDbType.VarChar).Value = intitule;
            cmd.Parameters.Add("id", OleDbType.Integer).Value = reminder_id;
            cmd.ExecuteNonQuery();
            dbCon.Close();
        }

        public void deleteReminder(int reminder_id)
        {
            string delete = "DELETE FROM Rappel WHERE id = ?";
            dbCon.Open();
            OleDbCommand cmd = new OleDbCommand(delete, dbCon);
            cmd.Parameters.Add("id", OleDbType.Integer).Value = reminder_id;
            cmd.ExecuteNonQuery();
            dbCon.Close();
        }

        public String getReminderDetails(int reminder_id)
        {
            string display = "SELECT date FROM Rappel "
                            + "WHERE id = ? ";
            dbCon.Open();
            OleDbCommand cmd = new OleDbCommand(display, dbCon);
            cmd.Parameters.Add("ID Reminder", OleDbType.Integer).Value = reminder_id;
            OleDbDataReader reader = cmd.ExecuteReader();
            String details = "";
            while (reader.Read())
            {
                details += (reader.GetString(0));
            }
            reader.Close();
            dbCon.Close();
            return details;
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

        public int findBreedIdByName(string breed_name)
        {
            string display = "SELECT id FROM Race "
                            + "WHERE intitule = ?";
            dbCon.Open();
            OleDbCommand cmd = new OleDbCommand(display, dbCon);      
            cmd.Parameters.Add("Intitule Race", OleDbType.VarChar).Value = breed_name;
            OleDbDataReader reader = cmd.ExecuteReader();
            int breed_id = -10;
            while (reader.Read())
            {
                Console.WriteLine("test");
                breed_id = reader.GetInt32(0);
            }
            reader.Close();
            dbCon.Close();
            return breed_id;
        }

        public int findSpecyIdByName(string specy_name)
        {
            string display = "SELECT id FROM Espece "
                            + "WHERE intitule = ?";
            dbCon.Open();
            OleDbCommand cmd = new OleDbCommand(display, dbCon);
            cmd.Parameters.Add("Intitule Espece", OleDbType.VarChar).Value = specy_name;
            OleDbDataReader reader = cmd.ExecuteReader();
            int specy_id = -1;
            while (reader.Read())
            {
                specy_id = reader.GetInt32(0);
            }
            reader.Close();
            dbCon.Close();
            return specy_id;
        }

        public int findPersonIdByName(string person_name, string person_firstname)
        {
            string display = "SELECT id FROM Personne "
                            + "WHERE nom = ? and prenom = ?";
            dbCon.Open();
            OleDbCommand cmd = new OleDbCommand(display, dbCon);
            cmd.Parameters.Add("Nom Personne", OleDbType.VarChar).Value = person_name;
            cmd.Parameters.Add("Prenom personne", OleDbType.VarChar).Value = person_firstname;
            OleDbDataReader reader = cmd.ExecuteReader();
            int person_id = -1;
            while (reader.Read()) {
                person_id = reader.GetInt32(0);
            }
            reader.Close();
            dbCon.Close();
            return person_id;
        }

        public List<string> getBreedsSpecy(int specy_id)
        {
            string get = "SELECT Race.id , Race.intitule from Race "
                        + "JOIN Espece on Espece.id = Race.EspeceID "
                        + "WHERE Espece.id = ?";
            dbCon.Open();
            OleDbCommand cmd = new OleDbCommand(get, dbCon);
            cmd.Parameters.Add("ID Espece", OleDbType.Integer).Value = specy_id;
            OleDbDataReader reader = cmd.ExecuteReader();
            List<string> breeds = new List<string>();
            while (reader.Read())
            {
                breeds.Add(reader.GetInt32(0) + ":" + reader.GetString(1));
            }
            reader.Close();
            dbCon.Close();
            return breeds;
        }

        public List<string> getAppointmentsAnimal(int animal_id)
        {
            string get = "SELECT Animal_RDV.id from Animal "
                        + "JOIN Animal_RDV on Animal_RDV.AnimalID = Animal.id "
                        + "WHERE Animal.id = ?";
            dbCon.Open();
            OleDbCommand cmd = new OleDbCommand(get, dbCon);
            cmd.Parameters.Add("ID Animal", OleDbType.Integer).Value = animal_id;
            OleDbDataReader reader = cmd.ExecuteReader();
            List<string> appointments = new List<string>();
            while (reader.Read())
            {
                appointments.Add(reader.GetString(0));
            }
            reader.Close();
            dbCon.Close();
            return appointments;
        }

        public List<string> getCaresAnimal(int animal_id)
        {
            string get = "SELECT * FROM Traitement "
                         + "JOIN Animal on Animal.id = Traitement.AnimalID "
                         + "WHERE Animal.id = ?";
            dbCon.Open();
            OleDbCommand cmd = new OleDbCommand(get, dbCon);
            cmd.Parameters.Add("ID Animal", OleDbType.Integer).Value = animal_id;
            OleDbDataReader reader = cmd.ExecuteReader();
            List<string> cares = new List<string>();
            while (reader.Read())
            {
                cares.Add(reader.GetString(0));
            }
            reader.Close();
            dbCon.Close();
            return cares;
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
            string get = "SELECT * FROM Espece";
            dbCon.Open();
            OleDbCommand cmd = new OleDbCommand(get, dbCon);
            OleDbDataReader reader = cmd.ExecuteReader();
            List<string> species = new List<string>();
            while (reader.Read())
            {
                species.Add(reader.GetInt32(0) + ":" + reader.GetString(1));
            }
            reader.Close();
            dbCon.Close();
            return species;
        }

        public List<string> getBreeds()
        {
            string get = "SELECT * FROM Race";
            dbCon.Open();
            OleDbCommand cmd = new OleDbCommand(get, dbCon);
            OleDbDataReader reader = cmd.ExecuteReader();
            List<string> breeds = new List<string>();
            while (reader.Read())
            {
                breeds.Add(reader.GetInt32(0) + ":" + reader.GetString(1) + ":" + reader.GetInt32(2));
            }
            reader.Close();
            dbCon.Close();
            return breeds;
        }

        public List<string> getPeople()
        {
            string get = "SELECT id,nom,prenom FROM Personne";
            dbCon.Open();
            OleDbCommand cmd = new OleDbCommand(get, dbCon);
            OleDbDataReader reader = cmd.ExecuteReader();
            List<string> people = new List<string>();
            while (reader.Read())
            {
                people.Add(reader.GetInt32(0) + ":" + reader.GetString(1) + ":" + reader.GetString(2));
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
            while (reader.Read())
            {
                reminders.Add(reader.GetInt32(0) + ":" + reader.GetString(1) + ":" + reader.GetString(2));
            }
            reader.Close();
            dbCon.Close();
            return reminders;
        }

        public string getReminder(int reminder_id)
        {
            string get = "SELECT intitule FROM Rappel "
                        + "WHERE id = ?";
            dbCon.Open();
            OleDbCommand cmd = new OleDbCommand(get, dbCon);
            cmd.Parameters.Add("ID Reminder", OleDbType.Integer).Value = reminder_id;
            OleDbDataReader reader = cmd.ExecuteReader();
            string reminder = "";
            while (reader.Read()) {
                reminder += reader.GetString(0);
            }
            reader.Close();
            dbCon.Close();
            return reminder;
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

        public void addAppointement(string date, string objet, int codeAnimal)
        {
            //Insert Into Rendez_Vous Join Animal_RDV ON Rendez_Vous.id = Animal_RDV.RDVID Join Animal on Animal.id = Animal_RDV.AnimalID

            string insert = "INSERT INTO Rendez_Vous OUTPUT Inserted.ID Values(?,?) ";
            dbCon.Open();
            OleDbCommand cmd = new OleDbCommand(insert, dbCon);
            cmd.Parameters.Add("Date", OleDbType.VarChar).Value = date;
            cmd.Parameters.Add("Objet", OleDbType.VarChar).Value = objet;
            cmd.ExecuteNonQuery();
            OleDbDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int rdvID = reader.GetInt32(0);
            dbCon.Close();

            insert = "INSERT INTO Animal_RDV Values(?,?)";
            dbCon.Open();
            OleDbCommand cmd2 = new OleDbCommand(insert, dbCon);
            cmd2.Parameters.Add("idAnimal", OleDbType.Integer).Value = codeAnimal;
            cmd2.Parameters.Add("RDVID", OleDbType.Integer).Value = rdvID;
            cmd2.ExecuteNonQuery();
            dbCon.Close();
        }

        public List<string> getAnimalsClient(int codeClient)
        {
            string display = "SELECT Animal.id, Animal.nom from Personne Join Animal ON Animal.PersonneID = Personne.id Where Personne.id = ?";
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

        public string getAppointment(int code_animal)
        {
            string display = "SELECT date, objet FROM Rendez_Vous Join Animal_RDV" 
                   + "ON Rendez_Vous.id = Animal_RDV.RDVID Join Animal on Animal.id = Animal_RDV.AnimalID where Animal.id = ?";
            dbCon.Open();
            OleDbCommand cmd = new OleDbCommand(display, dbCon);
            cmd.Parameters.Add("Code", OleDbType.Integer).Value = code_animal;
            cmd.ExecuteNonQuery();
            OleDbDataReader reader = cmd.ExecuteReader();
            reader.Read();
            string appointment = reader.GetString(0) + ":" + reader.GetString(1);
            reader.Close();
            dbCon.Close();
            return appointment;
        }

        public void modifyAppointment(string date, string objet, int codeAnimal)
        {
            //update t1 inner join (select * from t2) x on t1.c0 = x.c0 set t1.c1 = 10;

            string modify = "UPDATE Rendez_Vous SET Rendez_Vous.date = ?, Rendez_Vous.objet = ? Join Animal_RDV ON Rendez_Vous.id = Animal_RDV.RDVID "
                + "Join Animal on Animal.id = Animal_RDV.AnimalID where Animal.id = ?";
            dbCon.Open();
            OleDbCommand cmd = new OleDbCommand(modify, dbCon);
            cmd.Parameters.Add("date", OleDbType.Integer).Value = date;
            cmd.Parameters.Add("objet", OleDbType.Integer).Value = objet;
            cmd.Parameters.Add("idAnimal", OleDbType.Integer).Value = codeAnimal;
            cmd.ExecuteNonQuery();
            dbCon.Close();
        }

        public void cancelAppointment(int codeAnimal)
        {
            string cancel = "Delete From Rendez_Vous Join Animal_RDV ON Rendez_Vous.id = Animal_RDV.RDVID "
               + "Join Animal on Animal.id = Animal_RDV.AnimalID where Animal.id = ?";
            dbCon.Open();
            OleDbCommand cmd = new OleDbCommand(cancel, dbCon);
            cmd.Parameters.Add("idAnimal", OleDbType.Integer).Value = codeAnimal;
            cmd.ExecuteNonQuery();
            dbCon.Close();
        }

        //Care management
        public List<string> DisplayTreatments()
        {
            string display = "SELECT id,dateDebut,duree,nom,description from Traitement";
            dbCon.Open();
            OleDbCommand cmd = new OleDbCommand(display, dbCon);
            OleDbDataReader reader = cmd.ExecuteReader();
            List<string> treatments = new List<string>();
            while (reader.Read())
            {
                treatments.Add(reader.GetInt32(0) + ":" + reader.GetString(1) + ":" + reader.GetInt32(2) + ":" + reader.GetString(3) + ":" + reader.GetString(4));
            }
            reader.Close();
            dbCon.Close();
            return treatments;
        }

        public List<string> getTreatments(string animal)
        {
            string display = "SELECT id,dateDebut,duree,nom,description from Traitement where AnimalID = ?";
            dbCon.Open();
            OleDbCommand cmd = new OleDbCommand(display, dbCon);
            cmd.Parameters.Add("AnimalID", OleDbType.Integer).Value = Int32.Parse(animal.Split(':')[0]);
            OleDbDataReader reader = cmd.ExecuteReader();
            List<string> treatments = new List<string>();
            while (reader.Read())
            {
                treatments.Add(reader.GetInt32(0) + ":" + reader.GetString(1) + ":" + reader.GetInt32(2) + ":" + reader.GetString(3) + ":" + reader.GetString(4));
            }
            reader.Close();
            dbCon.Close();
            return treatments;
        }

        public void addTreatments(string animal, string nom, string dateDebut, string duree, string description)
        {
            string insert = "INSERT INTO Traitement  Values (?,?,?,?,?) ";
            dbCon.Open();
            OleDbCommand cmd = new OleDbCommand(insert, dbCon);
            cmd.Parameters.Add("dateDebut", OleDbType.VarChar).Value = dateDebut;
            cmd.Parameters.Add("duree", OleDbType.Integer).Value = Int32.Parse(duree);
            cmd.Parameters.Add("nom", OleDbType.VarChar).Value = nom;
            cmd.Parameters.Add("description", OleDbType.VarChar).Value = description;
            cmd.Parameters.Add("AnimalID", OleDbType.Integer).Value = Int32.Parse(animal.Split(':')[0]);
            cmd.ExecuteNonQuery();
            dbCon.Close();
        }

        //Stock Management
        public void addProduct(string reference, int quantite, double prix)
        {
            string insert = "INSERT INTO Produit Values (?,?,?) ";
            dbCon.Open();
            OleDbCommand cmd = new OleDbCommand(insert, dbCon);
            cmd.Parameters.Add("reference", OleDbType.VarChar).Value = reference;
            cmd.Parameters.Add("quantite", OleDbType.Integer).Value = quantite;
            cmd.Parameters.Add("prix", OleDbType.Double).Value = prix;
            cmd.ExecuteNonQuery();
            dbCon.Close();
        }

        public List<string> DisplayProducts()
        {
            string display = "SELECT id, intitule, quantite, prix from Produit";
            dbCon.Open();
            OleDbCommand cmd = new OleDbCommand(display, dbCon);
            OleDbDataReader reader = cmd.ExecuteReader();
            List<string> products = new List<string>();
            while (reader.Read())
            {
                products.Add(reader.GetInt32(0) + ":" + reader.GetString(1) + ":" + reader.GetInt32(2) + ":" + reader.GetDouble(3));
            }
            reader.Close();
            dbCon.Close();
            return products;
        }

        public void modifyPrice(string reference, double price)
        {
            string update = "UPDATE Produit SET prix= ? WHERE intitule = ?";
            dbCon.Open();
            OleDbCommand cmd = new OleDbCommand(update, dbCon);
            cmd.Parameters.Add("prix", OleDbType.Double).Value = price;
            cmd.Parameters.Add("intitule", OleDbType.VarChar).Value = reference;
            cmd.ExecuteNonQuery();
            dbCon.Close();
        }

        public void deleteProduct(int productId)
        {
            string delete = "DELETE FROM Produit WHERE id = ?";
            dbCon.Open();
            OleDbCommand cmd = new OleDbCommand(delete, dbCon);
            cmd.Parameters.Add("Code produit", OleDbType.Integer).Value = productId;
            cmd.ExecuteNonQuery();
            dbCon.Close();
        }

        public string detailsProduct(int productId)
        {
            string details = "SELECT id, intitule, quantite, prix from Produit where id = ?";
            dbCon.Open();
            OleDbCommand cmd = new OleDbCommand(details, dbCon);
            OleDbDataReader reader = cmd.ExecuteReader();
            string product = reader.GetInt32(0) + ":" + reader.GetString(1) + ":" + reader.GetInt32(2) + ":" + reader.GetDouble(3);
            reader.Close();
            dbCon.Close();
            return product;
        }

    }
}
