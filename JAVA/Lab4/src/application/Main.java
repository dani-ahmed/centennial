package application; 

import javafx.application.Application;
import javafx.geometry.Insets;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.control.CheckBox;
import javafx.scene.control.ComboBox;
import javafx.scene.control.Menu;
import javafx.scene.control.RadioButton;
import javafx.scene.control.TextArea;
import javafx.scene.control.Label;
import javafx.scene.control.ListView;
import javafx.scene.control.TextField;
import javafx.scene.control.ToggleGroup;
import javafx.scene.layout.GridPane;
import javafx.stage.Stage;

 
public class Main extends Application {
	
	Stage window;
	Button submitBtn;
	Label nameLbl , addLbl ,provinceLbl ,cityLbl ,postalLbl ,emailLbl,phoneLbl;
	TextField nameTf , addTf , provinceTf , cityTf , postalTf ,emailTf, phoneTf;
	CheckBox stdCouncilCheck,VolunteerCheck;
	ComboBox<String> courseComboBox;
	Menu classMenu;
	ListView<String> selectedCourses;
	TextArea displayTA;
	String selectedMajor;
	
    public static void main(String[] args) {
        launch(args);
    }
    
    @Override
    public void start(Stage primaryStage) {
    	
    	window = primaryStage;
    	window.setTitle("Student Info");
    	
        GridPane grid = new GridPane();
	     grid.setPadding(new Insets(10, 10, 10, 10));
	     grid.setHgap(10);
	     grid.setVgap(8);
	  
    	//Labels
    	nameLbl = new Label("Name:");
    	GridPane.setConstraints(nameLbl, 0, 0);
    	
    	addLbl = new Label("Address:");
    	GridPane.setConstraints(addLbl, 0, 1);
    	
    	provinceLbl  = new Label("Province :");
    	GridPane.setConstraints(provinceLbl, 0, 2);
    	
    	cityLbl  = new Label("City:");
    	GridPane.setConstraints(cityLbl, 0, 3);
    	
    	postalLbl  = new Label("Postal Code:");
    	GridPane.setConstraints(postalLbl, 0, 4);
    	
    	emailLbl  = new Label("Email:");
    	GridPane.setConstraints(emailLbl, 0, 5);
    	
    	phoneLbl  = new Label("Phone Number:");
    	GridPane.setConstraints(phoneLbl, 0, 6);
    	
    	//Textfields for above labels
    	
    	nameTf = new TextField();
    	GridPane.setConstraints(nameTf, 1, 0);
    	
    	addTf = new TextField();
    	GridPane.setConstraints(addTf, 1, 1);
    	
    	provinceTf  = new TextField();
    	GridPane.setConstraints(provinceTf, 1, 2);
    	
    	cityTf  = new TextField();
    	GridPane.setConstraints(cityTf, 1, 3);
    	
    	postalTf  = new TextField();
    	GridPane.setConstraints(postalTf, 1, 4);
    	
    	emailTf  = new TextField();
    	GridPane.setConstraints(emailTf, 1, 5);
    	
    	phoneTf  = new TextField();
    	GridPane.setConstraints(phoneTf, 1, 6);
    	
    	//student council and volunteer work CheckBoxes
    	
    	stdCouncilCheck = new CheckBox("Student Council");
    	GridPane.setConstraints(stdCouncilCheck, 0, 7);
    	
    	VolunteerCheck = new CheckBox("Volunteer Work");
    	GridPane.setConstraints(VolunteerCheck, 0, 8);
    	
    	
    	
    	//selected courses Listview
    	
    	
    	selectedCourses = new ListView<>();
    	selectedCourses.setPrefHeight(60);

    	GridPane.setConstraints(selectedCourses, 0, 9);
    	
    	//ChoiceBox
    	
    	courseComboBox = new ComboBox<>();
    	GridPane.setConstraints(courseComboBox, 0, 10 );
    	courseComboBox.setPromptText("Select One");
    	
    	courseComboBox.setOnAction(e->{
    		if(!selectedCourses.getItems().contains(courseComboBox.getValue()) && courseComboBox.getValue() != null ) {
    			selectedCourses.getItems().addAll(courseComboBox.getValue());
    		}
    	}
    		);
    	ToggleGroup classToggle  = new ToggleGroup();
    	RadioButton compSci = new RadioButton("Computer Science");
    	RadioButton business = new RadioButton("Business");
    	
    	compSci.setToggleGroup(classToggle);
    	business.setToggleGroup(classToggle);
    	
    	GridPane.setConstraints(compSci, 0, 11);
    	GridPane.setConstraints(business, 0, 12);
    	
    	// Set values for Selector
    	classToggle.selectedToggleProperty().addListener((o, oldToggle, newToggle)->{
    		if(newToggle == compSci) {
    			selectedMajor = "Computer Science";
    			courseComboBox.getItems().addAll("Java","Web Application","Cyber Security");
    			courseComboBox.getItems().remove("Finance");
    			courseComboBox.getItems().remove("Marketing");
    			courseComboBox.getItems().remove("Accounting");

    		}
    		else if(newToggle == business) {
    			selectedMajor = "Business";
    			courseComboBox.getItems().addAll("Finance","Marketing","Accounting");
    			courseComboBox.getItems().remove("Java");
    			courseComboBox.getItems().remove("Web Application");
    			courseComboBox.getItems().remove("Cyber Security");
    		}
    		else {}
    	});
    
    	//TextArea
    	
    	displayTA = new TextArea(); 
    	displayTA.setPrefWidth(400);
    	GridPane.setConstraints(displayTA, 0, 13, 5, 2);
    	
    	//Display button
    	submitBtn = new Button("Submit");
    	GridPane.setConstraints(submitBtn, 2, 12);
    	
    	submitBtn.setOnAction(e->{
    		String stdName = nameTf.getText();
    		String address = addTf.getText();
    		String province = provinceTf.getText();
    		String city = cityTf.getText();
    		String postal = postalTf.getText();
    		String email = emailTf.getText();
    		String phone = phoneTf.getText();
    		String stdCouncil = "No";
    		String volunteer = "No";
    		
    		if(stdCouncilCheck.isSelected()) {stdCouncil = "Yes";}
    		if(VolunteerCheck.isSelected()) {volunteer = "Yes";}
    		
    		//
    		if(stdName == null || stdName.isEmpty() || address == null || address.isEmpty() || province == null || province.isEmpty() || city == null || city.isEmpty() ||
    				postal == null || postal.isEmpty() || email == null || email.isEmpty()
    				) {}
    		else {
    			displayTA.appendText("\nStudent Info\n"
    					+ "\n Student Name:" + stdName  
    					+"\n Address:" + address
    					+ "\n Province: " + province
    					+ "\n City: " + city
    					+"\n Postal: " + postal
    					+"\n Email: " + email
    					+"\n Phone: " + phone
    					+"\n Student Council:" + stdCouncil
    					+"\n Volunteer Work:"+ volunteer
    					+"\n Selected Major:" + selectedMajor
    					+"\n Courses:" + selectedCourses.getItems()
    					);	
    			
    		}	
    	});
    	//add labels
	     grid.getChildren().addAll( nameLbl , addLbl ,provinceLbl ,cityLbl ,postalLbl ,emailLbl,phoneLbl);
	     //add Texfields
	     grid.getChildren().addAll( nameTf , addTf , provinceTf , cityTf , postalTf ,emailTf,phoneTf);
	     // add checkboxes
	     grid.getChildren().addAll(stdCouncilCheck, VolunteerCheck);
	     //add comboboox ,listview ,text area
	     grid.getChildren().addAll(courseComboBox , compSci , business, selectedCourses,displayTA);
	     //add display button
	     grid.getChildren().addAll(submitBtn);
	     
	     Scene scene = new Scene(grid);
	     window.setScene(scene);
	     window.show();
	}

}