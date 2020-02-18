namespace MeuHelp.Models
{
    public class Home
    {
        public Physicalperson Physicalperson { get; set; }
        public int PhysicalpersonId { get; set; }
        public Collaborator Collaborator { get; set; }
        public int CollaboratorId { get; set; }
        public Home()
        {
        }
        public Home(Physicalperson physicalperson, int physicalpersonId, Collaborator collaborator, int collaboratorId)
        {
            Physicalperson = physicalperson;
            PhysicalpersonId = physicalpersonId;
            Collaborator = collaborator;
            CollaboratorId = collaboratorId;
        }
    }
}
