using Adapter.Example2;

LegacyDatabase legacyDatabase = new LegacyDatabase();
DatabaseAdapter databaseAdapter = new DatabaseAdapter(legacyDatabase);

NewSistem newSistem = new NewSistem(databaseAdapter);

newSistem.SaveDate("Important data");
newSistem.LoadData();

