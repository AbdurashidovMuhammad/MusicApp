﻿namespace N_Tier.Core.DTOs;

public class PaymentResponseDTO
{
    public bool Success { get; set; }
    public string Message { get; set; }
    public int NewBalance { get; set; }
}
