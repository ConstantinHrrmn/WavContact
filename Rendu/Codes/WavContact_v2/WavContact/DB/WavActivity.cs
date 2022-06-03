using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WavContact.Models;

namespace WavContact.DB
{
    public class WavActivity
    {
        const string CREATION = "Creation du projet ";
        const string AJOUT_DOCUMENT = "Document ajoute ";
        const string SUPPRESSION_DOCUMENT = "Document supprime ";
        const string MODIFICATION_DOCUMENT = "Document mis a jour ";

        public static void AjoutActiviteCustom(User u, Project p, string activite)
        {
            WavContactPDO.AddActivityLog(u, p, activite);
        }

        public static void AjoutActiviteCustom(User u, string activite)
        {
            Project p = new Project();
            p.Id = 0;
            WavContactPDO.AddActivityLog(u, p, activite);
        }

        public static void AjoutActiviteCustom(string activite)
        {
            User u = new User();
            u.Id = 0;
            Project p = new Project();
            p.Id = 0;
            WavContactPDO.AddActivityLog(u, p, activite);
        }

        public static void CreationProjet(User u, Project p)
        {
            WavContactPDO.AddActivityLog(u, p, CREATION+ ": " + p.Name);
            p.Id = 0;
            WavContactPDO.AddActivityLog(u, p, CREATION + ": " + p.Name);
        }

        public static void AjoutDocument(User u, Project p, string d)
        {
            WavContactPDO.AddActivityLog(u, p, AJOUT_DOCUMENT + ": " + d);
        }

        public static void SuppressionDocument(User u, Project p, string d)
        {
            WavContactPDO.AddActivityLog(u, p, SUPPRESSION_DOCUMENT + ": " + d);
        }

        public static void ModificationDocument(User u, Project p, string d)
        {
            WavContactPDO.AddActivityLog(u, p, MODIFICATION_DOCUMENT + ": " + d);
        }

        public static List<Activity> GetActivities(Project p)
        {
            return WavContactPDO.GetActivitiesForProject(p);
        }
    }
}
