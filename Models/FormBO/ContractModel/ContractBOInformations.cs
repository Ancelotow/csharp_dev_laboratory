using System;
using DevLaboratory.Models.Interfaces.BOInterfaces;

namespace DevLaboratory.Models.FormBO.ContractModel
{
    public class ContractBOInformations : TabContractBO 
    {
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        public int? IdType { get; set; }
        public int? IdAPECITAStatus { get; set; }

        /// <summary>
        /// Ajouter ou modifie l'objet en base de données
        /// </summary>
        public override void AddOrUpdateInDb()
        {
            // TODO: Créer et appeler la procédure stockée afin d'ajouter ou modifier les données dans la base de données
            throw new NotImplementedException();
        }
        

        /// <summary>
        /// Charge les données
        /// <param name="uuid">L'UUID de l'objet</param>
        /// <exception cref="UuidNotExistedException">L'UUID n'éxiste pas</exception>
        /// <exception cref="UuidNotInitializedException">L'UUID n'est pas initialisé</exception>
        /// </summary>
        public override void LoadAttributesFromDbWithUuid(string uuid)
        {
            /// TODO: Créer et appeler la procédure stockée afin de récupérer les données de l'entête
            throw new NotImplementedException();
        }
    }
}