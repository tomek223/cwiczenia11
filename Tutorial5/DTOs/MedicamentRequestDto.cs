namespace Tutorial5.DTOs;

public class MedicamentRequestDto
{
    public int IdMedicament { get; set; }
    public int Dose { get; set; }
    public string Description { get; set; } = null!;
}