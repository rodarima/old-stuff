#pragma once

using namespace System;
using namespace System::ComponentModel;
using namespace System::Collections;
using namespace System::Windows::Forms;
using namespace System::Data;
using namespace System::Drawing;


namespace Proyecto1 {

	/// <summary>
	/// Resumen de f_principal
	///
	/// ADVERTENCIA: si cambia el nombre de esta clase, deber� cambiar la
	///          propiedad 'Nombre de archivos de recursos' de la herramienta de compilaci�n de recursos administrados
	///          asociada con todos los archivos .resx de los que depende esta clase. De lo contrario,
	///          los dise�adores no podr�n interactuar correctamente con los
	///          recursos adaptados asociados con este formulario.
	/// </summary>
	public ref class f_principal : public System::Windows::Forms::Form
	{
	public:
		f_principal(void)
		{
			InitializeComponent();
			//
			//TODO: agregar c�digo de constructor aqu�
			//
		}

	protected:
		/// <summary>
		/// Limpiar los recursos que se est�n utilizando.
		/// </summary>
		~f_principal()
		{
			if (components)
			{
				delete components;
			}
		}

	private:
		/// <summary>
		/// Variable del dise�ador requerida.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// M�todo necesario para admitir el Dise�ador. No se puede modificar
		/// el contenido del m�todo con el editor de c�digo.
		/// </summary>
		void InitializeComponent(void)
		{
			this->SuspendLayout();
			// 
			// f_principal
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(233, 100);
			this->Name = L"f_principal";
			this->Text = L"f_principal";
			this->Load += gcnew System::EventHandler(this, &f_principal::f_principal_Load);
			this->ResumeLayout(false);

		}
#pragma endregion
	private: System::Void f_principal_Load(System::Object^  sender, System::EventArgs^  e) {
			 }
	};
}
