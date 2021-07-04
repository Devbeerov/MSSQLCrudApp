namespace MSSQLCrudApp.Models
{
    public class Employee
    {
        // JIT compiler will inline all Properties, so there won't be perfomance loss.
        // Virtual Properties because of lazy NHibernate initialization mode.

        public virtual int ID { get; set; }
        public virtual string FullName { get; set; }
        public virtual float Salary { get; set; }

        #region Stats

        public virtual float? Speed { get; set; }
        public virtual float? Accuracy { get; set; }
        public virtual float? Efficiency { get; set; }

        #endregion
    }
}
