using System;

namespace tenantapi.ViewModels
{
    public class InvitationRequest {
        public Guid resourceId  {get; set;}
        public Guid tenantId  {get; set;}
        public ResourceRole role  {get; set;}
        public string toEmail {get; set;}
        public ResourceType resourceType {get; set;}
    }
    public class InvitationView
    {
        public Guid id { get; set; }
        public string toEmail{ get; set; }
        public Guid createdBy{ get; set; }
        public DateTime sentDate{ get; set; }
        public Guid tenantId{ get; set; }

        public Guid resourceId{ get; set; }
        public ResourceType resourceType{ get; set; }
        public string resourceName{ get; set; }
        public ResourceRole role{ get; set; }
        public InvitationStatus status{ get; set; }
        public DateTime expiry { get; set; }
    }

    public enum InvitationStatus
    {
         Active,
         UserResponded,
         Cancelled,
         Accepted,
         Expired,
         Aborted
    }

    public enum ResourceRole
    {
        Admin,
        Contributor,

        Owner,
        Reader
    }

    public enum ResourceType
    {
        Tenant,
        Subscription,
        ResourceGroup,
        Service
    }
}