using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATTA_Prep_Class_3___Notes
{
    class Orc
    {
        // Methods
        // contructors have no type but needs an access level

        public Orc(int maxHp)
        {
            m_maxHp = maxHp;
            m_currentHp = m_maxHp;
            AssignID();
        }
        public Orc()
        {
            
            m_maxHp = 100;
            m_currentHp = m_maxHp;
            AssignID(); 
        }
        private void AssignID()
        {
            m_ID = m_Idcounter++; 
        }

        // Fields

        private int m_maxHp;
        private int m_currentHp;
        private int m_ID;

        // Static Data

        static private int m_Idcounter = 0;

        static public string Warcry
        {
            get
            {
                return "Blood and Thunder!!!";
            }
        }


        // Properties - help regulate the fields


       public int OrcID
        {
           get
            {
                return m_ID;
            }
        }
       

        public int MaxHp
        {
            get
            {
                return m_maxHp;
            }
        }
        public int CurrentHp
        {
            get
            {
                return m_currentHp;
            }
            set
            {
                m_currentHp = value;
                if (value < 0)
                {
                    m_currentHp = 0;
                }
                if (value > m_maxHp)
                {
                    m_currentHp = m_maxHp;
                }
            }
        }
    }
}
