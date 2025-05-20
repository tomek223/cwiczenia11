﻿namespace Tutorial5.Models;

public class PrescriptionMedicament
{
    public int IdMedicament { get; set; }
    public Medicament Medicament { get; set; } = null!;

    public int IdPrescription { get; set; }
    public Prescription Prescription { get; set; } = null!;

    public int Dose { get; set; }
    public string Description { get; set; } = null!;
}