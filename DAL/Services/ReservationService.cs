using DAL.Entities;
using DAL.Mapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Services
{
    public class ReservationService
    {
        private string connectionString { get; set; } = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog =EcoTravelDB;Integrated Security = True";
        public IEnumerable<Reservation> Get()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [idReservation], [idClient], [idCanceler], [dateDebut], [dateFin], [nbPersonne], [nbEnfant], [dateAnnulation] FROM [Reservation]";
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToReservation();
                        }
                    }
                }
            }
        }

        public Reservation Get(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [idReservation], [idClient], [idCanceler], [dateDebut], [dateFin], [nbPersonne], [nbEnfant], [dateAnnulation] FROM [Reservation] WHERE [idReservation] = @id";
                    command.Parameters.AddWithValue("id", id);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read()) return reader.ToReservation();
                        return null;
                    }
                }
            }
        }

        public int Insert(Reservation entity)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "INSERT INTO [Reservation] ( [idClient], [idCanceler], [dateDebut], [dateFin], [nbPersonne], [nbEnfant], [dateAnnulation]) OUTPUT [inserted].[idReservation] VALUES (@idClient, @idCanceler, @dateDebut, @dateFin, @nbPersonne, @nbEnfant, @dateAnnulation)";

                    command.Parameters.AddWithValue("idClient", entity.idClient);
                    command.Parameters.AddWithValue("idCanceler", entity.idCanceler);
                    command.Parameters.AddWithValue("dateDebut", entity.dateDebut);
                    command.Parameters.AddWithValue("dateFin", entity.dateFin);
                    command.Parameters.AddWithValue("nbPersonne", entity.nbPersonne);
                    command.Parameters.AddWithValue("nbEnfant", entity.nbEnfant);
                    command.Parameters.AddWithValue("dateAnnulation", entity.dateAnnulation);
                    connection.Open();
                    return (int)command.ExecuteScalar();
                }
            }
        }

        public bool Update(int id, Reservation entity)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"UPDATE [Reservation]
											SET [idClient] = @idClient,
												[idCanceler] = @idCanceler,
												[dateDebut] = @dateDebut,
												[dateFin] = @dateFin,
												[nbPersonne] = @nbPersonne,
												[nbEnfant] = @nbEnfant,
                                                [dateAnnulation] = @dateAnnulation
											WHERE [idReservation] = @id";
                    command.Parameters.AddWithValue("idClient", entity.idClient);
                    command.Parameters.AddWithValue("idCanceler", entity.idCanceler);
                    command.Parameters.AddWithValue("dateDebut", entity.dateDebut);
                    command.Parameters.AddWithValue("dateFin", entity.dateFin);
                    command.Parameters.AddWithValue("nbPersonne", entity.nbPersonne);
                    command.Parameters.AddWithValue("nbEnfant", entity.nbEnfant);
                    command.Parameters.AddWithValue("dateAnnulation", entity.dateAnnulation);
                    connection.Open();
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
