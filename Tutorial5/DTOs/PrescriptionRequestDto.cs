namespace Tutorial5.DTOs;

public class PrescriptionRequestDto
{
    public PatientDto Patient { get; set; } = null!;
    public int IdDoctor { get; set; }
    public DateTime Date { get; set; }
    public DateTime DueDate { get; set; }
    public List<MedicamentRequestDto> Medicaments { get; set; } = new();
}