using System;
using System.Collections.Generic;
using System.Text;

namespace PaternsFactrorys
{
    public interface IBread
    {
        void Bake();
        void Provide();
    }
    class Bun : IBread
    {
        public void Provide()
        {
            throw new NotImplementedException();
        }

        public void Bake()
        {
            throw new NotImplementedException();
        }
    }

    class Loaf : IBread
    {
        public void Provide()
        {
            throw new NotImplementedException();
        }

        public void Bake()
        {
            throw new NotImplementedException();
        }
    }
    class Cake : IBread
    {
        public void Provide()
        {
            throw new NotImplementedException();
        }

        public void Bake()
        {
            throw new NotImplementedException();
        }
    }



    public interface IBreadFactory
    {
        IBread CreateFan();
    }

    public class TableFanFactory : IBreadFactory
    {
        public IBread CreateFan()
        {
            throw new NotImplementedException();
        }
    }
    public class AutoFanFactory : IBreadFactory
    {
        public IBread CreateFan()
        {
            throw new NotImplementedException();
        }
    }

    public class PCFanFactory : IBreadFactory
    {
        public IBread CreateFan()
        {
            throw new NotImplementedException();
        }
    }

    public class HairFanFactory : IBreadFactory
    {
        public IBread CreateFan()
        {
            throw new NotImplementedException();
        }
    }
}
