namespace DevLaboratory.Models.Interfaces.BOInterfaces
{
    public abstract class BOHeader : IDbManagment
    {
        public int Id { get; set; }
        public int IdBase { get; set; }
        public string Uuid { get; set; }

        /// <summary>
        /// Ajoute ou modifie les données dans la base de données
        /// </summary>
       public abstract void AddOrUpdateInDb();

        /// <summary>
        /// Charge les attributes de l'objet depuis la base de données avec l'UUID
        /// </summary>
        /// <param name="uuid">L'UUID de l'objet</param>
        public abstract void LoadAttributesFromDbWithUuid(string uuid);
    }
}