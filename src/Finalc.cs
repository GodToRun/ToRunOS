using System;
using System.Collections.Generic;
using System.Text;

namespace ToRun_OS
{
    class Finalc
    {
        /*public static void Interprint(string line)
        {
            string[] arg = line.Split(" ");
            string[] targ = line.Split("\"");
            if (line[0] == '\"' && !NoString(arg[0]).Contains("="))
            {
                Console.WriteLine(targ[1]);
            }
            else if (line.Contains("nstr"))
            {
                Console.WriteLine(NoString(arg[1]));
            }
            else if (NoString(line).Contains("="))
            {
                string[] earg = line.Split("=");
                if (ReturnType(earg[1]) == typeof(Str))
                {
                    try { Str.strs.Remove(Str.get(earg[0])); } catch { }
                    Str s = new Str(earg[0], targ[1]);
                }
                else if (ReturnType(earg[1]) == typeof(Bool))
                {
                    try { Bool.bools.Remove(Bool.get(earg[0])); } catch { }
                    Bool s = new Bool(earg[0], Convert.ToBoolean(earg[1]));
                }
                else if (ReturnType(earg[1]) == typeof(Int))
                {
                    try { Int.ints.Remove(Int.get(earg[0])); } catch { }
                    Int s = new Int(earg[0], Convert.ToInt32(earg[1]));
                }
                else if (ReturnType(earg[1]) == typeof(Null) && VariableReturnType(earg[1]) != typeof(Null))
                {
                    if (VariableReturnType(earg[0]) == typeof(Str))
                    {
                        Str.get(earg[0]).i = Str.get(earg[1]).i;
                    }
                    else if (VariableReturnType(earg[0]) == typeof(Bool))
                    {
                        Bool.get(earg[0]).i = Bool.get(earg[1]).i;
                    }
                    else if (VariableReturnType(earg[0]) == typeof(Int))
                    {
                        Int.get(earg[0]).i = Int.get(earg[1]).i;
                    }
                }
                else if (earg[1] == "in")
                {
                    try { Str.strs.Remove(Str.get(earg[0])); } catch { }
                    Str I = new Str(earg[0], Convert.ToString(ReturnData(earg[1]).i));
                }
                else
                {
                    try { Int.ints.Remove(Int.get(earg[0])); } catch { }
                    Int I = new Int(earg[0], Convert.ToInt32(ReturnData(earg[1]).i));
                }
            }
            else if (line.Contains("cl"))
            {
                foreach (Str str in Str.strs)
                    Console.WriteLine("STR " + str.name);
                foreach (Bool str in Bool.bools)
                    Console.WriteLine("BOOL " + str.name);
                foreach (Int str in Int.ints)
                    Console.WriteLine("INT " + str.name);
            }
            else if (VariableReturnType(NoString(line)) != typeof(Null))
            {
                line = NoString(line);
                if (VariableReturnType(line) == typeof(Str))
                {
                    Console.WriteLine(Str.get(line).i);
                }
                else if (VariableReturnType(line) == typeof(Bool))
                {
                    Console.WriteLine(Bool.get(line).i);
                }
                else if (VariableReturnType(line) == typeof(Int))
                {
                    Console.WriteLine(Int.get(line).i);
                }

            }
            else
            {
                Console.WriteLine(ReturnData(line).i);
            }
        }
        static PrimitiveType ReturnData(string s)
        {
            try { return new Int(Convert.ToInt32(s)); } catch { }
            try { return new Bool(Convert.ToBoolean(s)); } catch { }
            if (s[0] == '\"')
                return new Str(s);
            if (VariableReturnType(NoString(s)) == typeof(Int))
            {
                return Int.get(NoString(s));
            }
            else if (VariableReturnType(NoString(s)) == typeof(Str))
            {
                return Str.get(NoString(s));
            }
            else if (VariableReturnType(NoString(s)) == typeof(Bool))
            {
                return Bool.get(NoString(s));
            }
            else if (NoString(s) == "in")
            {
                return new Str(Console.ReadLine(), 0);
            }
            else if (VariableReturnType(NoString(s)) == typeof(Null))
            {
                if (Convert.ToInt32(multiply(s).i) != -1)
                    return multiply(s);
                else if (Convert.ToInt32(division(s).i) != -1)
                    return division(s);
                else if (Convert.ToInt32(plus(s).i) != -1)
                    return plus(s);
                else if (Convert.ToInt32(minus(s).i) != -1)
                    return minus(s);
            }
            return new Null();
        }
        static Int multiply(string s)
        {
            int RESULT = 1;
            string[] multiply = s.Split("*");
            foreach (string S in multiply)
            {
                try
                {
                    RESULT *= Convert.ToInt32(S);
                }
                catch
                {
                    try
                    {
                        RESULT *= Convert.ToInt32(Int.get(S).i);
                    }
                    catch
                    {
                        return new Int(-1);
                    }
                }
            }
            return new Int(RESULT);
        }
        static Int division(string s)
        {
            string[] division = s.Split("/");
            int RESULT = 0;
            try { RESULT = Convert.ToInt32(division[0]) * Convert.ToInt32(division[0]); } catch { try { RESULT = Convert.ToInt32(Int.get(division[0]).i) * Convert.ToInt32(Int.get(division[0]).i); } catch { } }
            foreach (string S in division)
            {
                try
                {
                    RESULT /= Convert.ToInt32(S);
                }
                catch
                {
                    try
                    {
                        RESULT /= Convert.ToInt32(Int.get(S).i);
                    }
                    catch
                    {
                        return new Int(-1);
                    }
                }
            }
            return new Int(RESULT);
        }
        static Int plus(string s)
        {
            int RESULT = 0;
            string[] division = s.Split("+");
            foreach (string S in division)
            {
                try
                {
                    RESULT += Convert.ToInt32(S);
                }
                catch
                {
                    try
                    {
                        RESULT += Convert.ToInt32(Int.get(S).i);
                    }
                    catch
                    {
                        return new Int(-1);
                    }
                }
            }
            return new Int(RESULT);
        }
        static Int minus(string s)
        {
            string[] M = s.Split("-");
            int RESULT = Convert.ToInt32(M[0]);
            foreach (string S in M)
            {
                try
                {
                    RESULT -= Convert.ToInt32(S);
                }
                catch
                {
                    try
                    {
                        RESULT -= Convert.ToInt32(Int.get(S).i);
                    }
                    catch
                    {
                        return new Int(-1);
                    }
                }
            }
            return new Int(RESULT);
        }
        static Type VariableReturnType(string name)
        {
            try
            {
                if (Str.get(name) != null)
                {
                    return typeof(Str);
                }
                else if (Bool.get(name) != null)
                {
                    return typeof(Bool);
                }
                else if (Int.get(name) != null)
                {
                    return typeof(Int);
                }
                return typeof(Null);
            }
            catch
            {
                return typeof(Null);
            }
        }
        static Type ReturnType(string s)
        {
            if (s.Contains("\""))
                return typeof(Str);
            else if (s == "false" || s == "true")
                return typeof(Bool);
            else
                try { Convert.ToInt32(s); return typeof(Int); } catch { return typeof(Null); }
        }
        public static string NoString(string l)
        {
            try
            {
                string[] arg = null;
                arg = l.Split("\"");
                string ToReturn = "";
                try { arg[1] = ""; } catch { }
                foreach (string s in arg)
                    ToReturn += s;
                return ToReturn;
            }
            catch { }
            return "";
        }
        class Null : PrimitiveType
        {

        }
        class Int : PrimitiveType
        {
            //public int i;
            public static List<Int> ints = new List<Int>();
            public Int(string name, int value)
            {
                isRef = true;
                ints.Add(this);
                this.name = name;
                this.i = value;
            }
            public Int(string name)
            {
                isRef = true;
                ints.Add(this);
                this.name = name;
            }
            public Int(int I)
            {
                this.i = I;
            }
            public static Int get(string Name)
            {
                foreach (Int S in ints)
                    if (S.name == Name)
                        return S;
                return null;
            }
        }
        class Str : PrimitiveType
        {
            //public string i;
            public static List<Str> strs = new List<Str>();
            public Str(string name, string value)
            {
                isRef = true;
                strs.Add(this);
                this.name = name;
                this.i = value;
            }
            public Str(string name)
            {
                isRef = true;
                strs.Add(this);
                this.name = name;
            }
            public Str(string STR, int status)
            {
                this.i = STR;
            }
            public static Str get(string Name)
            {
                foreach (Str S in strs)
                    if (S.name == Name)
                        return S;
                return null;
            }
        }
        class Bool : PrimitiveType
        {

            //public bool i;
            public static List<Bool> bools = new List<Bool>();
            public Bool(string name, bool value)
            {
                isRef = true;
                bools.Add(this);
                this.name = name;
                this.i = value;
            }
            public Bool(bool B)
            {
                this.i = B;
            }
            public Bool(string name)
            {
                isRef = true;
                bools.Add(this);
                this.name = name;
            }
            public static Bool get(string Name)
            {
                foreach (Bool S in bools)
                    if (S.name == Name)
                        return S;
                return null;
            }

        }
    }
    class PrimitiveType
    {
        public string name;
        public bool isRef = false;
        public int id;
        public object i;
    }*/
    }
}
