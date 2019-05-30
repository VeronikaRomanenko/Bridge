using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            BuildCompany company = new BuildCompany(new BrickRoomBuilder());
            company.BuildFoundation();
            company.BuildRoom();
            company.BuildRoof();
            company = new BuildCompany(new ConcreteRoomBuilder());
            company.BuildFoundation();
            company.BuildRoom();
            company.BuildRoof();
        }
    }
    class BuildCompany
    {
        RoomBuilder builder;
        public BuildCompany(RoomBuilder builder)
        {
            this.builder = builder;
        }
        public void BuildFoundation()
        {
            Console.WriteLine("Фундамент построен");
        }
        public void BuildRoom()
        {
            builder.BuildRoom();
        }
        public void BuildRoof()
        {
            Console.WriteLine("Крыша построена");
        }
    }
    abstract class RoomBuilder
    {
        public abstract void BuildRoom();
    }
    class ConcreteRoomBuilder : RoomBuilder
    {
        public override void BuildRoom()
        {
            Console.WriteLine("Комната из бетона построена");
        }
    }
    class BrickRoomBuilder : RoomBuilder
    {
        public override void BuildRoom()
        {
            Console.WriteLine("Комната из кирпича построена");
        }
    }
}