pipeline {
	agent any	  
	  stages {     
	  stage ('Restore packages') {
	    steps {
		    echo 'Restoring packages....'
		    bat 'dotnet restore'
	    }
	  }       
	  stage ('Clean project') {
	    steps {
		    echo 'Cleaning the output of the previous build....'
		    bat 'dotnet clean'
	    }
	  }	  	  	   
	  stage ('Build project') {
	    steps {
		    echo 'Building the project....'
		    bat 'dotnet build --configuration Release'
	    }
	  }
	  stage ('Test project') {
	    steps {
		    echo 'Testing the project....'
		    bat 'dotnet test'
	    }
	  }
	  stage ('Publish framework-dependent') {
	    steps {
		    echo 'Publishing framework-dependent application....'
		    bat 'dotnet publish -f netcoreapp3.1 -c Release --self-contained false'
	    }
	  }	  
	  stage ('Run application') {
	    steps {
		    echo 'Running the project....'
		    bat 'dotnet run -p ./Dental/Dental.csproj &'
	    }
	  }
	}
    }
