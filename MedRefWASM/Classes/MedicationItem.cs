namespace MedRefWASM.Classes
{
    public class MedicationItem
    {
        public string medicationName { get; set; } = "null";
        public bool flagRenal { get; set; } = false;
        public bool flagDialysis { get; set; } = false;
        public bool flagHepatic { get; set; } = false;

        public MedicationItem(string MedicationName, bool Flag_Renal, bool Flag_Dialysis, bool Flag_Hepatic)
        {
            medicationName = MedicationName;
            flagRenal = Flag_Renal;
            flagDialysis = Flag_Dialysis;
            flagHepatic = Flag_Hepatic;
        }
    }
}

