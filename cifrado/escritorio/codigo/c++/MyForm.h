#pragma once
#include <string>
#include "Cesarh.h"
#include "TrInversa.h"
#include "TInversaxGrp.h"

namespace CifradoCesar {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Resumen de MyForm
	/// </summary>
	public ref class MyForm : public System::Windows::Forms::Form
	{
	public:
		MyForm(void)
		{
			InitializeComponent();
			//
			//TODO: agregar código de constructor aquí
			//
		}

	protected:
		/// <summary>
		/// Limpiar los recursos que se estén utilizando.
		/// </summary>
		~MyForm()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::TextBox^  textBoxTextoPlano;
	private: System::Windows::Forms::Label^  labelTextPLain;
	private: System::Windows::Forms::Label^  labelDesplazamiento;

	private: System::Windows::Forms::Label^  labelTextCifrado;
	private: System::Windows::Forms::TextBox^  textBoxTextCifrado;


	private: System::Windows::Forms::NumericUpDown^  numUpDownDesplaza;
	private: System::Windows::Forms::Panel^  panelPosicionInversaxGrp;
	private: System::Windows::Forms::Label^  labelTIxGrp;
	private: System::Windows::Forms::Label^  labelTextCifradoxGrp;
	private: System::Windows::Forms::TextBox^  textBoxTxtCifxGrp;
	private: System::Windows::Forms::Label^  labelPosInverxGrp;
	private: System::Windows::Forms::NumericUpDown^  numUDxGrp;
	private: System::Windows::Forms::Panel^  panelCesar;
	private: System::Windows::Forms::Label^  labelCesar;
	private: System::Windows::Forms::Panel^  panelTPosicionInversa;
	private: System::Windows::Forms::Label^  labelTInversa;
	private: System::Windows::Forms::Label^  labelTextCifInversa;
	private: System::Windows::Forms::TextBox^  textBoxTPInversa;

	private:
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		void InitializeComponent(void)
		{
			this->textBoxTextoPlano = (gcnew System::Windows::Forms::TextBox());
			this->labelTextPLain = (gcnew System::Windows::Forms::Label());
			this->labelDesplazamiento = (gcnew System::Windows::Forms::Label());
			this->labelTextCifrado = (gcnew System::Windows::Forms::Label());
			this->textBoxTextCifrado = (gcnew System::Windows::Forms::TextBox());
			this->numUpDownDesplaza = (gcnew System::Windows::Forms::NumericUpDown());
			this->panelPosicionInversaxGrp = (gcnew System::Windows::Forms::Panel());
			this->labelTIxGrp = (gcnew System::Windows::Forms::Label());
			this->labelTextCifradoxGrp = (gcnew System::Windows::Forms::Label());
			this->textBoxTxtCifxGrp = (gcnew System::Windows::Forms::TextBox());
			this->labelPosInverxGrp = (gcnew System::Windows::Forms::Label());
			this->numUDxGrp = (gcnew System::Windows::Forms::NumericUpDown());
			this->panelCesar = (gcnew System::Windows::Forms::Panel());
			this->labelCesar = (gcnew System::Windows::Forms::Label());
			this->panelTPosicionInversa = (gcnew System::Windows::Forms::Panel());
			this->labelTInversa = (gcnew System::Windows::Forms::Label());
			this->labelTextCifInversa = (gcnew System::Windows::Forms::Label());
			this->textBoxTPInversa = (gcnew System::Windows::Forms::TextBox());
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^  >(this->numUpDownDesplaza))->BeginInit();
			this->panelPosicionInversaxGrp->SuspendLayout();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^  >(this->numUDxGrp))->BeginInit();
			this->panelCesar->SuspendLayout();
			this->panelTPosicionInversa->SuspendLayout();
			this->SuspendLayout();
			// 
			// textBoxTextoPlano
			// 
			this->textBoxTextoPlano->Location = System::Drawing::Point(106, 12);
			this->textBoxTextoPlano->Multiline = true;
			this->textBoxTextoPlano->Name = L"textBoxTextoPlano";
			this->textBoxTextoPlano->Size = System::Drawing::Size(491, 50);
			this->textBoxTextoPlano->TabIndex = 0;
			this->textBoxTextoPlano->TextChanged += gcnew System::EventHandler(this, &MyForm::textBoxTextoPlano_TextChanged);
			// 
			// labelTextPLain
			// 
			this->labelTextPLain->AutoSize = true;
			this->labelTextPLain->Location = System::Drawing::Point(36, 24);
			this->labelTextPLain->Name = L"labelTextPLain";
			this->labelTextPLain->Size = System::Drawing::Size(64, 13);
			this->labelTextPLain->TabIndex = 1;
			this->labelTextPLain->Text = L"Texto Plano";
			// 
			// labelDesplazamiento
			// 
			this->labelDesplazamiento->AutoSize = true;
			this->labelDesplazamiento->Location = System::Drawing::Point(7, 34);
			this->labelDesplazamiento->Name = L"labelDesplazamiento";
			this->labelDesplazamiento->Size = System::Drawing::Size(82, 13);
			this->labelDesplazamiento->TabIndex = 2;
			this->labelDesplazamiento->Text = L"Desplazamiento";
			// 
			// labelTextCifrado
			// 
			this->labelTextCifrado->AutoSize = true;
			this->labelTextCifrado->Location = System::Drawing::Point(7, 57);
			this->labelTextCifrado->Name = L"labelTextCifrado";
			this->labelTextCifrado->Size = System::Drawing::Size(70, 13);
			this->labelTextCifrado->TabIndex = 4;
			this->labelTextCifrado->Text = L"Texto Cifrado";
			// 
			// textBoxTextCifrado
			// 
			this->textBoxTextCifrado->Location = System::Drawing::Point(10, 76);
			this->textBoxTextCifrado->Multiline = true;
			this->textBoxTextCifrado->Name = L"textBoxTextCifrado";
			this->textBoxTextCifrado->Size = System::Drawing::Size(148, 109);
			this->textBoxTextCifrado->TabIndex = 5;
			this->textBoxTextCifrado->TextChanged += gcnew System::EventHandler(this, &MyForm::textBoxTextCifrado_TextChanged);
			// 
			// numUpDownDesplaza
			// 
			this->numUpDownDesplaza->Location = System::Drawing::Point(94, 32);
			this->numUpDownDesplaza->Name = L"numUpDownDesplaza";
			this->numUpDownDesplaza->Size = System::Drawing::Size(64, 20);
			this->numUpDownDesplaza->TabIndex = 8;
			this->numUpDownDesplaza->ValueChanged += gcnew System::EventHandler(this, &MyForm::numUpDownDesplaza_ValueChanged);
			// 
			// panelPosicionInversaxGrp
			// 
			this->panelPosicionInversaxGrp->BorderStyle = System::Windows::Forms::BorderStyle::FixedSingle;
			this->panelPosicionInversaxGrp->Controls->Add(this->labelTIxGrp);
			this->panelPosicionInversaxGrp->Controls->Add(this->labelTextCifradoxGrp);
			this->panelPosicionInversaxGrp->Controls->Add(this->textBoxTxtCifxGrp);
			this->panelPosicionInversaxGrp->Controls->Add(this->labelPosInverxGrp);
			this->panelPosicionInversaxGrp->Controls->Add(this->numUDxGrp);
			this->panelPosicionInversaxGrp->Location = System::Drawing::Point(416, 76);
			this->panelPosicionInversaxGrp->Name = L"panelPosicionInversaxGrp";
			this->panelPosicionInversaxGrp->Size = System::Drawing::Size(181, 203);
			this->panelPosicionInversaxGrp->TabIndex = 9;
			this->panelPosicionInversaxGrp->Tag = L"";
			// 
			// labelTIxGrp
			// 
			this->labelTIxGrp->AutoSize = true;
			this->labelTIxGrp->Location = System::Drawing::Point(44, 11);
			this->labelTIxGrp->Name = L"labelTIxGrp";
			this->labelTIxGrp->Size = System::Drawing::Size(83, 13);
			this->labelTIxGrp->TabIndex = 4;
			this->labelTIxGrp->Text = L"T. Inversa x Grp";
			// 
			// labelTextCifradoxGrp
			// 
			this->labelTextCifradoxGrp->AutoSize = true;
			this->labelTextCifradoxGrp->Location = System::Drawing::Point(18, 57);
			this->labelTextCifradoxGrp->Name = L"labelTextCifradoxGrp";
			this->labelTextCifradoxGrp->Size = System::Drawing::Size(70, 13);
			this->labelTextCifradoxGrp->TabIndex = 3;
			this->labelTextCifradoxGrp->Text = L"Texto Cifrado";
			// 
			// textBoxTxtCifxGrp
			// 
			this->textBoxTxtCifxGrp->Location = System::Drawing::Point(18, 76);
			this->textBoxTxtCifxGrp->Multiline = true;
			this->textBoxTxtCifxGrp->Name = L"textBoxTxtCifxGrp";
			this->textBoxTxtCifxGrp->Size = System::Drawing::Size(146, 109);
			this->textBoxTxtCifxGrp->TabIndex = 2;
			// 
			// labelPosInverxGrp
			// 
			this->labelPosInverxGrp->AutoSize = true;
			this->labelPosInverxGrp->Location = System::Drawing::Point(15, 32);
			this->labelPosInverxGrp->Name = L"labelPosInverxGrp";
			this->labelPosInverxGrp->Size = System::Drawing::Size(36, 13);
			this->labelPosInverxGrp->TabIndex = 1;
			this->labelPosInverxGrp->Text = L"Grupo";
			// 
			// numUDxGrp
			// 
			this->numUDxGrp->Location = System::Drawing::Point(79, 30);
			this->numUDxGrp->Name = L"numUDxGrp";
			this->numUDxGrp->Size = System::Drawing::Size(85, 20);
			this->numUDxGrp->TabIndex = 0;
			this->numUDxGrp->ValueChanged += gcnew System::EventHandler(this, &MyForm::numUDxGrp_ValueChanged);
			// 
			// panelCesar
			// 
			this->panelCesar->BorderStyle = System::Windows::Forms::BorderStyle::FixedSingle;
			this->panelCesar->Controls->Add(this->labelCesar);
			this->panelCesar->Controls->Add(this->textBoxTextCifrado);
			this->panelCesar->Controls->Add(this->labelTextCifrado);
			this->panelCesar->Controls->Add(this->labelDesplazamiento);
			this->panelCesar->Controls->Add(this->numUpDownDesplaza);
			this->panelCesar->Location = System::Drawing::Point(12, 76);
			this->panelCesar->Name = L"panelCesar";
			this->panelCesar->Size = System::Drawing::Size(173, 203);
			this->panelCesar->TabIndex = 10;
			// 
			// labelCesar
			// 
			this->labelCesar->AutoSize = true;
			this->labelCesar->Location = System::Drawing::Point(50, 11);
			this->labelCesar->Name = L"labelCesar";
			this->labelCesar->Size = System::Drawing::Size(34, 13);
			this->labelCesar->TabIndex = 9;
			this->labelCesar->Text = L"Cesar";
			// 
			// panelTPosicionInversa
			// 
			this->panelTPosicionInversa->BorderStyle = System::Windows::Forms::BorderStyle::FixedSingle;
			this->panelTPosicionInversa->Controls->Add(this->labelTInversa);
			this->panelTPosicionInversa->Controls->Add(this->labelTextCifInversa);
			this->panelTPosicionInversa->Controls->Add(this->textBoxTPInversa);
			this->panelTPosicionInversa->Location = System::Drawing::Point(209, 76);
			this->panelTPosicionInversa->Name = L"panelTPosicionInversa";
			this->panelTPosicionInversa->Size = System::Drawing::Size(181, 203);
			this->panelTPosicionInversa->TabIndex = 11;
			// 
			// labelTInversa
			// 
			this->labelTInversa->AutoSize = true;
			this->labelTInversa->Location = System::Drawing::Point(57, 11);
			this->labelTInversa->Name = L"labelTInversa";
			this->labelTInversa->Size = System::Drawing::Size(55, 13);
			this->labelTInversa->TabIndex = 2;
			this->labelTInversa->Text = L"T. Inversa";
			// 
			// labelTextCifInversa
			// 
			this->labelTextCifInversa->AutoSize = true;
			this->labelTextCifInversa->Location = System::Drawing::Point(21, 58);
			this->labelTextCifInversa->Name = L"labelTextCifInversa";
			this->labelTextCifInversa->Size = System::Drawing::Size(70, 13);
			this->labelTextCifInversa->TabIndex = 1;
			this->labelTextCifInversa->Text = L"Texto Cifrado";
			// 
			// textBoxTPInversa
			// 
			this->textBoxTPInversa->Location = System::Drawing::Point(16, 76);
			this->textBoxTPInversa->Multiline = true;
			this->textBoxTPInversa->Name = L"textBoxTPInversa";
			this->textBoxTPInversa->Size = System::Drawing::Size(148, 109);
			this->textBoxTPInversa->TabIndex = 0;
			this->textBoxTPInversa->TextChanged += gcnew System::EventHandler(this, &MyForm::textBoxTPInversa_TextChanged);
			// 
			// MyForm
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(628, 291);
			this->Controls->Add(this->panelTPosicionInversa);
			this->Controls->Add(this->panelCesar);
			this->Controls->Add(this->panelPosicionInversaxGrp);
			this->Controls->Add(this->labelTextPLain);
			this->Controls->Add(this->textBoxTextoPlano);
			this->Name = L"MyForm";
			this->Text = L"MyForm";
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^  >(this->numUpDownDesplaza))->EndInit();
			this->panelPosicionInversaxGrp->ResumeLayout(false);
			this->panelPosicionInversaxGrp->PerformLayout();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^  >(this->numUDxGrp))->EndInit();
			this->panelCesar->ResumeLayout(false);
			this->panelCesar->PerformLayout();
			this->panelTPosicionInversa->ResumeLayout(false);
			this->panelTPosicionInversa->PerformLayout();
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	private: System::Void textBoxTextoPlano_TextChanged(System::Object^  sender, System::EventArgs^  e) {
			 cesar();
			 Tinversa();
			 TxGrp();
		}
	private: System::Void textBoxTextCifrado_TextChanged(System::Object^  sender, System::EventArgs^  e) {
		 }		 
private: System::Void textBoxTextoDescifrado_TextChanged(System::Object^  sender, System::EventArgs^  e) {
		 }
private: System::Void numUpDownDesplaza_ValueChanged(System::Object^  sender, System::EventArgs^  e) {
			 cesar();
		 }
private: System::Void textBoxTPInversa_TextChanged(System::Object^  sender, System::EventArgs^  e) {
		 }
private: System::Void numUDxGrp_ValueChanged(System::Object^  sender, System::EventArgs^  e) {
			 TxGrp();
		 }
		 void cesar(){
			try{
				 int des = 0;
				 des = Convert::ToInt16(numUpDownDesplaza->Value);
				 std::string out = "";
				 for(int indice = 0; indice < textBoxTextoPlano->Text->Length;indice++)
					 out = out + Cesar::cifrar(textBoxTextoPlano->Text[indice],des);
				 textBoxTextCifrado->Text =  gcnew String(out.c_str());
			}catch(int e){}
		}
		 void Tinversa(){
			 std::string oracion = "";
			 std::string word = "";
				 for(int indice = 0; indice < textBoxTextoPlano->Text->Length;indice++)
					 word = TramspInversa::tranformar(textBoxTextoPlano->Text[indice],word,&oracion);
				 textBoxTPInversa->Text =  gcnew String(word.c_str());
		 }
		 void TxGrp(){
			 int des = Convert::ToInt16(numUDxGrp->Value);
			 int posicion = 0;
			 std::string grupos ="";
			 std::string word = "";
				 for(int indice = 0; indice < textBoxTextoPlano->Text->Length;indice++)
					 word = TIxGrp::TInxGrp(textBoxTextoPlano->Text[indice],des,&posicion,word,&grupos);
				 textBoxTxtCifxGrp->Text =  gcnew String(word.c_str());
		 }
};
}
