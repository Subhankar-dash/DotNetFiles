using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThread
{
    public class Account
    {
        public int Getincome(int fees , int PatienceCount)
        {
            return fees * PatienceCount;
        }
        public double Tax(int Income)
        {
            return Income * 0.2;
        }
        public double HospitalShare(int Income)
        {
            return Income * 0.15;
        }
        public double GrossSalary(int Income , double Tax , double HospitalShare)
        {
            return Income - Tax - HospitalShare;
        }
    }
}
