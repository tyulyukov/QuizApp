//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuizServer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Statistics
    {
        public System.Guid Id { get; set; }
        public System.DateTime PassDate { get; set; }
        public System.TimeSpan PassTime { get; set; }
        public int Score { get; set; }
        public int MaxScore { get; set; }
        public System.Guid TestId { get; set; }
        public System.Guid UserId { get; set; }
    
        public virtual Tests Tests { get; set; }
        public virtual Users Users { get; set; }
    }
}
