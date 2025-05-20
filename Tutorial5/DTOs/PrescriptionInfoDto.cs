namespace Tutorial5.DTOs;

public class PrescriptionInfoDto
{
    public int IdPrescription { get; set; }
    public DateTime Date { get; set; }
    public DateTime DueDate { get; set; }
    public DoctorDto Doctor { get; set; } = null!;
    public List<MedicamentInfoDto> Medicaments { get; set; } = new();
}