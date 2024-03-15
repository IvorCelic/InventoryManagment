﻿namespace InventoryManagementAPP.Models
{
    /// <summary>
    /// Data Transfer Object (DTO) representing a read-only view of a location.
    /// </summary>
    public record WarehouseDTORead(int id, string warehouseName, string description);

    /// <summary>
    /// Data Transfer Object (DTO) representing the data needed for inserting or updating a location.
    /// </summary>
    public record WarehouseDTOInsertUpdate(string warehouseName, string description);

    /// <summary>
    /// Data Transfer Object (DTO) representing a read-only view of a person
    /// </summary>
    public record EmployeeDTORead(int id, string firstName, string lastName, string email, string password);

    /// <summary>
    /// Data Transfer Object (DTO) representing the data needed for inserting or updating a person
    /// </summary>
    public record EmployeeDTOInsertUpdate(string firstName, string lastName, string email, string password);
}
