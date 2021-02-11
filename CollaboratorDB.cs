using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class CollaboratorDB
    {
        private Collaborator[] collaborators;
        private const int MAX = 50;

        public CollaboratorDB()
        {
            collaborators = new Collaborator[MAX];
        }

        public bool AddCollaborator(string firstname, string lastname, string state, string location, string email, string mobile, string distance, string instagram)
        {
            int index = -1;
            for(int i = 0; i < MAX; i++)
            {
                if(collaborators[i] == null)
                {
                    index = i;
                    break;
                }
            }
            if(index != -1)
            {
                collaborators[index] = new Collaborator(firstname, lastname, state, location, email, mobile, distance, instagram);
                return true;
            }
            return false;
        }
    }
}
