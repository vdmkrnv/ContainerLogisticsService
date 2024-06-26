﻿namespace Services.Services.Contracts.ContainerType;

/// <summary>
/// DTO типа контейнера
/// </summary>
public class ContainerTypeDto
{
    /// <summary>
    /// Идентификатор типа контейнера
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Имя типа
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    ///  Цена за день аренды
    /// </summary>
    public double PricePerDay { get; set; }
}