namespace Numerical_Stroop.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class DB : DbContext
    {
        // Your context has been configured to use a 'DB' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Numerical_Stroop.Models.DB' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'DB' 
        // connection string in the application configuration file.
        public DB()
            : base("name=DB")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }

        public virtual DbSet<WorkerId> WorkerIds { get; set; }

        public virtual DbSet<Scenario> Scenarios { get; set; }

        public virtual DbSet<ManipulationCheck> ManipulationChecks { get; set; }

        public virtual DbSet<CountingTaskResponse> CountingTaskResponses { get; set; }

        public virtual DbSet<PracticeCountingTaskResponse> CountingTaskPracticeResponses { get; set; }

        public virtual DbSet<NumericPostPracticeQuestion> PostCountingPracticeQuestions { get; set; }


        public virtual DbSet<SequenceTaskResponse> SequenceTaskResponses { get; set; }

        public virtual DbSet<MemoryTaskPracticeResponse> MemoryTaskPracticeResponses { get; set; }

        public virtual DbSet<MemoryTaskResponse> MemoryTaskResponses { get; set; }

        public virtual DbSet<PracticeSequenceTaskResponse> SequenceTaskPracticeResponses { get; set; }

        public virtual DbSet<SequencePostPracticeQuestion> PostSequencePracticeQuestions { get; set; }


        public virtual DbSet<FollowUpQuestions> FollowUpQuestions { get; set; }

        public virtual DbSet<QuestionnaireQuestions> QuestionnaireQuestions { get; set; }

        public virtual DbSet<Demographics> Demographics { get; set; }

    }
}