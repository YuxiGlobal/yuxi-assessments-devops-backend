namespace Yuxi.Devops.Assessment.Core.Vehicles
{
    public class VehicleAccessory
    {
        public VehicleAccessory()
        {

        }
        
        public long Code { get; set; }

        public int AccessoryCode { get; set; }

        public long VehicleCode { get; set; }

        public short Quantity { get; set; }

        public virtual Accessory Accessory { get; set; }

        public virtual Vehicle Vehicle { get; set; }

    }
}
