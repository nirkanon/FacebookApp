using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace B15_Ex03_Nir_304855521_Hen_304841851.Utils
{
    public class Statuses : IEnumerable, IEnumerable<string>
    {
        private readonly User m_LoggedUser;

        private List<Status> m_Statuses;

        public Statuses()
        {
            m_Statuses = new List<Status>();
            m_LoggedUser = LoggedUserSingleton.Instance.GetUser();
            foreach (FacebookWrapper.ObjectModel.Status status in m_LoggedUser.Statuses)
            {
                m_Statuses.Add(new Status(status.Id, status.Message));
            }
        }

        public IEnumerator<string> GetEnumerator()
        {
            for (int i = 0; i < m_Statuses.Count; ++i)
            {
                yield return m_Statuses[i].Text;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < m_Statuses.Count; ++i)
            {
                yield return m_Statuses[i].Text;
            }
        }
    }
}
