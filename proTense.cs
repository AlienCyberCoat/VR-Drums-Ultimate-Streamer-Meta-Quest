namespace ledtest {
	Serial* SP = new Serial("COM3");

	[STAThread]
	void main(array<String^>^ args) {

		Application::EnableVisualStyles();
		Application::SetCompatibleTextRenderingDefault(false);

		ledtest::led form;
		Application::Run(%form);
	}

	void sendState(int state) {
		if (state == 1)
			SP->WriteData("1", 1);
		if (state == 0)
			SP->WriteData("0", 1);
	}	
        
        void readState() {
		char* iState;

		while (SP->IsConnected()) {
			SP->ReadData(iState, 255);
			printf(iState);
		}
	}