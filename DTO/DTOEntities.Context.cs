﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DTO
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class TourManagerEntities : DbContext
    {
        public TourManagerEntities()
            : base("name=TourManagerEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountType> AccountTypes { get; set; }
        public DbSet<Constant> Constants { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeRole> EmployeeRoles { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<Tour> Tours { get; set; }
        public DbSet<TourCategory> TourCategories { get; set; }
        public DbSet<TourGroup> TourGroups { get; set; }
        public DbSet<TourGroupFee> TourGroupFees { get; set; }
        public DbSet<TourGroupHotel> TourGroupHotels { get; set; }
        public DbSet<TourPrice> TourPrices { get; set; }
        public DbSet<TourSite> TourSites { get; set; }
        public DbSet<Transport> Transports { get; set; }
        public DbSet<TransportsTourGroup> TransportsTourGroups { get; set; }
    
        public virtual ObjectResult<GetCustomerById_Result> GetCustomerById(string id)
        {
            var idParameter = id != null ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetCustomerById_Result>("GetCustomerById", idParameter);
        }
    
        public virtual ObjectResult<GetCustomerList_Result> GetCustomerList()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetCustomerList_Result>("GetCustomerList");
        }
    
        public virtual ObjectResult<GetDestinationById_Result> GetDestinationById(string id)
        {
            var idParameter = id != null ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetDestinationById_Result>("GetDestinationById", idParameter);
        }
    
        public virtual ObjectResult<GetDestinationList_Result> GetDestinationList()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetDestinationList_Result>("GetDestinationList");
        }
    
        public virtual ObjectResult<GetEmployeeById_Result> GetEmployeeById(string id)
        {
            var idParameter = id != null ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetEmployeeById_Result>("GetEmployeeById", idParameter);
        }
    
        public virtual int GetEmployeeByTourGroupId(Nullable<int> tour_group_id)
        {
            var tour_group_idParameter = tour_group_id.HasValue ?
                new ObjectParameter("tour_group_id", tour_group_id) :
                new ObjectParameter("tour_group_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("GetEmployeeByTourGroupId", tour_group_idParameter);
        }
    
        public virtual ObjectResult<GetEmployeeList_Result> GetEmployeeList()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetEmployeeList_Result>("GetEmployeeList");
        }
    
        public virtual ObjectResult<GetPassengerById_Result> GetPassengerById(string customer_id, string tour_group_id)
        {
            var customer_idParameter = customer_id != null ?
                new ObjectParameter("customer_id", customer_id) :
                new ObjectParameter("customer_id", typeof(string));
    
            var tour_group_idParameter = tour_group_id != null ?
                new ObjectParameter("tour_group_id", tour_group_id) :
                new ObjectParameter("tour_group_id", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetPassengerById_Result>("GetPassengerById", customer_idParameter, tour_group_idParameter);
        }
    
        public virtual ObjectResult<GetPassengerByTourGroupId_Result> GetPassengerByTourGroupId(string tour_group_id)
        {
            var tour_group_idParameter = tour_group_id != null ?
                new ObjectParameter("tour_group_id", tour_group_id) :
                new ObjectParameter("tour_group_id", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetPassengerByTourGroupId_Result>("GetPassengerByTourGroupId", tour_group_idParameter);
        }
    
        public virtual ObjectResult<GetStatusById_Result> GetStatusById(string id)
        {
            var idParameter = id != null ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetStatusById_Result>("GetStatusById", idParameter);
        }
    
        public virtual ObjectResult<GetStatusList_Result> GetStatusList()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetStatusList_Result>("GetStatusList");
        }
    
        public virtual int GetTourGroupList()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("GetTourGroupList");
        }
    
        public virtual ObjectResult<GetTourList_Result> GetTourList()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetTourList_Result>("GetTourList");
        }
    
        public virtual ObjectResult<GetAllPassengers_Result> GetCustomersByTourGroupId(Nullable<int> tourgroup_id)
        {
            var tourgroup_idParameter = tourgroup_id.HasValue ?
                new ObjectParameter("tourgroup_id", tourgroup_id) :
                new ObjectParameter("tourgroup_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllPassengers_Result>("GetCustomersByTourGroupId", tourgroup_idParameter);
        }
    
        public virtual ObjectResult<GetAllPassengers_Result> GetAllPassengers()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllPassengers_Result>("GetAllPassengers");
        }
    
        public virtual int addEmployeeTourGroup(Nullable<int> employee_id, Nullable<int> tourgroup_id)
        {
            var employee_idParameter = employee_id.HasValue ?
                new ObjectParameter("employee_id", employee_id) :
                new ObjectParameter("employee_id", typeof(int));
    
            var tourgroup_idParameter = tourgroup_id.HasValue ?
                new ObjectParameter("tourgroup_id", tourgroup_id) :
                new ObjectParameter("tourgroup_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("addEmployeeTourGroup", employee_idParameter, tourgroup_idParameter);
        }
    
        public virtual int addPassenger(Nullable<int> customer_id, Nullable<int> tourgroup_id)
        {
            var customer_idParameter = customer_id.HasValue ?
                new ObjectParameter("customer_id", customer_id) :
                new ObjectParameter("customer_id", typeof(int));
    
            var tourgroup_idParameter = tourgroup_id.HasValue ?
                new ObjectParameter("tourgroup_id", tourgroup_id) :
                new ObjectParameter("tourgroup_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("addPassenger", customer_idParameter, tourgroup_idParameter);
        }
    
        public virtual int addTransportTourGroup(Nullable<int> transport_id, Nullable<int> tourgroup_id)
        {
            var transport_idParameter = transport_id.HasValue ?
                new ObjectParameter("transport_id", transport_id) :
                new ObjectParameter("transport_id", typeof(int));
    
            var tourgroup_idParameter = tourgroup_id.HasValue ?
                new ObjectParameter("tourgroup_id", tourgroup_id) :
                new ObjectParameter("tourgroup_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("addTransportTourGroup", transport_idParameter, tourgroup_idParameter);
        }
    
        public virtual int deleteEmployeeTransport(Nullable<int> employee_id, Nullable<int> tourgroup_id)
        {
            var employee_idParameter = employee_id.HasValue ?
                new ObjectParameter("employee_id", employee_id) :
                new ObjectParameter("employee_id", typeof(int));
    
            var tourgroup_idParameter = tourgroup_id.HasValue ?
                new ObjectParameter("tourgroup_id", tourgroup_id) :
                new ObjectParameter("tourgroup_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("deleteEmployeeTransport", employee_idParameter, tourgroup_idParameter);
        }
    
        public virtual int deletePassenger(Nullable<int> customer_id, Nullable<int> tourgroup_id)
        {
            var customer_idParameter = customer_id.HasValue ?
                new ObjectParameter("customer_id", customer_id) :
                new ObjectParameter("customer_id", typeof(int));
    
            var tourgroup_idParameter = tourgroup_id.HasValue ?
                new ObjectParameter("tourgroup_id", tourgroup_id) :
                new ObjectParameter("tourgroup_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("deletePassenger", customer_idParameter, tourgroup_idParameter);
        }
    
        public virtual int deleteTransportTourGroup(Nullable<int> transport_id, Nullable<int> tourgroup_id)
        {
            var transport_idParameter = transport_id.HasValue ?
                new ObjectParameter("transport_id", transport_id) :
                new ObjectParameter("transport_id", typeof(int));
    
            var tourgroup_idParameter = tourgroup_id.HasValue ?
                new ObjectParameter("tourgroup_id", tourgroup_id) :
                new ObjectParameter("tourgroup_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("deleteTransportTourGroup", transport_idParameter, tourgroup_idParameter);
        }
    
        public virtual ObjectResult<GetAllEmployeeTourGroup_Result> GetAllEmployeeTourGroup()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllEmployeeTourGroup_Result>("GetAllEmployeeTourGroup");
        }
    
        public virtual ObjectResult<GetAllTransportTourGroup_Result> GetAllTransportTourGroup()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllTransportTourGroup_Result>("GetAllTransportTourGroup");
        }
    
        public virtual int GetEmployeeByTourGroupId1(string tour_group_id)
        {
            var tour_group_idParameter = tour_group_id != null ?
                new ObjectParameter("tour_group_id", tour_group_id) :
                new ObjectParameter("tour_group_id", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("GetEmployeeByTourGroupId1", tour_group_idParameter);
        }
    
        public virtual int GetPassengerByTourGroupId1(string tour_group_id)
        {
            var tour_group_idParameter = tour_group_id != null ?
                new ObjectParameter("tour_group_id", tour_group_id) :
                new ObjectParameter("tour_group_id", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("GetPassengerByTourGroupId1", tour_group_idParameter);
        }
    }
}