using System;
using System.Collections.Generic;

namespace Zadanie7.Models;

public partial class ClientTrip
{
    public int IdClient { get; set; }

    public int IdTrip { get; set; }

    public DateTime RegisteredAt { get; set; }

    public DateTime? PaymentDate { get; set; }

    public virtual Client IdClientNavigation { get; set; } = null!;

    public virtual Trip IdTripNavigation { get; set; } = null!;

    public ClientTrip(int idClient, int idTrip, DateTime registeredAt, DateTime? paymentDate)
    {
        IdClient = idClient;
        IdTrip = idTrip;
        RegisteredAt = registeredAt;
        PaymentDate = paymentDate;
    }
}
