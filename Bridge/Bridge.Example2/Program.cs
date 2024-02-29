
using Bridge.Example2;


IEngine petrolEngine = new PetrolEngine();
Vehicle carWithPetrolEngine = new Car(petrolEngine);
carWithPetrolEngine.Drive();


IEngine electricEngine = new ElectricEngine();
Vehicle carWithElectricEngine = new Car(electricEngine);
carWithElectricEngine.Drive();
