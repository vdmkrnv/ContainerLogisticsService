﻿namespace Domain;

/// <summary>
/// Доменная сущность контейнера
/// </summary>
public class Container : BaseEntity
{
	/// <summary>
	/// Номер ISO
	/// </summary>
	public string IsoNumber { get; set; }

	/// <summary>
	/// Идентификатор типа контейнера
	/// </summary>
	public Guid TypeId { get; set; }
	
	/// <summary>
	/// Свойство для доступа к типу контейнера (для EFCore)
	/// </summary>
	public ContainerType Type { get; set; }

	/// <summary>
	/// Статус занятости контейнера
	/// </summary>
	public bool IsEngaged { get; set; }
	
	/// <summary>
	/// До какого числа занят контейнер
	/// </summary>
	public DateTime? EngagedUntil { get; set; }
	
	/// <summary>
	/// Удален ли контейнер
	/// </summary>
	public bool IsDeleted { get; set; }
}