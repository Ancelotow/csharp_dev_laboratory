namespace DevLaboratory.Models.Interfaces.BOInterfaces
{
    public abstract class BOTabManagment<THeader, TTab> : IDbManagment where THeader : BOHeader where TTab : BOTab
    {
        public THeader Header { get; set; }
        public TTab Tab { get; set; }

        public void AddOrUpdateInDb()
        {
            Header.AddOrUpdateInDb();
            Tab.AddOrUpdateInDb();
        }

        public void LoadAttributesFromDbWithUuid(string uuid)
        {
            Header.LoadAttributesFromDbWithUuid(uuid);
            Tab.LoadAttributesFromDbWithUuid(uuid);
        }
    }
}