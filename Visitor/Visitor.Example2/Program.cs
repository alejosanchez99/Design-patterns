
using Visitor.Example2;

TV tv = new TV();
Phone phone = new Phone();
Computer computer = new Computer();
RepairService repairService = new RepairService();

tv.Accept(repairService);
phone.Accept(repairService);
computer.Accept(repairService);