namespace DevLaboratory.Models.Interfaces
{
    /// <summary>
    /// Interface pour gérer les données dans la base de données
    /// </summary>
    public interface IDbManagment
    {
        /// <summary>
        /// Ajoute ou modifie les données dans la base de données
        /// </summary>
        void AddOrUpdateInDb();

        /// <summary>
        /// Charge les attributes de l'objet depuis la base de données avec l'UUID
        /// </summary>
        /// <param name="uuid">L'UUID de l'objet</param>
        void LoadAttributesFromDbWithUuid(string uuid);
    }
}