pipeline {
    agent any

    stages {
        stage('Clone Repository') {
            steps {
                // Clone the source code repository
                git branch: 'main', url: 'https://github.com/ganesh20101/dot_net_app.git'
            }
        }

        stage('Build') {
            steps {
                // Navigate to the correct directory and build the application
                dir('/var/lib/jenkins/workspace/.net app/MyWebApp') {
                    sh 'dotnet build'
                }
            }
        }

        stage('Run') {
            steps {
                // Run the application on the specified port
                dir('/var/lib/jenkins/workspace/.net app/MyWebApp') {
                    sh 'dotnet run --urls "http://*:5239"'
                }
            }
        }
    }
}
