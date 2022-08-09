using MedRefWASM.Classes;

namespace MedRefWASM.Services
{
    public class MedicationItemService
    {
        private string[] medications = new[] { "lisinopril", "atorvastatin", "metoprolol", "venlafaxine", "duloxetine", "amphetamine", "methylphenidate", "doxyrubicin", "carvedilol", "apixaban", "rivaroxaban", "fluoxetine", "paroxetine", "duloxetine" };
        public List<MedicationItem> items { get; set; }

        public List<MedicationItem> GetItems()
        {
            Random random = new Random();
            items = new List<MedicationItem>();


            foreach (string med in medications)
            {
                //creates a meditem with a real medication string and a random bool for each flag
                MedicationItem meditem = new MedicationItem(med, Convert.ToBoolean(random.Next(0, 1)), Convert.ToBoolean(random.Next(0, 1)), Convert.ToBoolean(random.Next(0, 1)));
                items.Add(meditem);
            }

            return items;
        }

    }
}