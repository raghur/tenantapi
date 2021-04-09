using System;
using tenantapi.ViewModels;

public class ResourceRolesByUserDenormalized {
    public Guid tenantId { get; set; }
    public Guid resourceId { get; set; }
    public string resourceType { get; set; }
    public ResourceRole role { get; set; }
    
}