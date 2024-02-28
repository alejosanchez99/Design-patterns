using Adapter.Example1;

CommunicationSystem communicationSystem = new CommunicationSystem();

EnglishSpeaker englishSpeaker = new EnglishSpeaker();

communicationSystem.StartConversation(englishSpeaker, "How's it going?", "I'm pretty well, thank you");

SpanishSpeaker spanishSpeaker = new SpanishSpeaker();
Translator translator = new Translator(spanishSpeaker);

communicationSystem.StartConversation(translator, "¿Cómo estás?", "Muy bien, gracias");

