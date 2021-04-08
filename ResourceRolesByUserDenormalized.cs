using System;

public class ResourceRolesByUserDenormalized {
    public Guid tenantId { get; set; }
    public Guid resourceId { get; set; }
    public string resourceType { get; set; }
    public string role { get; set; }
    
}