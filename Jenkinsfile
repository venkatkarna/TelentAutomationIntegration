pipeline {
    agent any

    environment {
        DOTNET_PATH = 'C:\\Program Files\\dotnet' // Path to .NET SDK
        SOLUTION_PATH = 'C:\\Users\\venkatesh.b\\Desktop\\DailyCheck_WebAutomation.sln' // Path to the solution file
    }

    stages {
        stage('Checkout') {
            steps {
                echo 'Checking out the code...'
                checkout scm
            }
        }

        stage('Restore Dependencies') {
            steps {
                echo 'Restoring NuGet dependencies...'
                bat "\"${DOTNET_PATH}\\dotnet.exe\" restore \"${SOLUTION_PATH}\""
            }
        }

        stage('Build') {
            steps {
                echo 'Building the solution...'
                bat "\"${DOTNET_PATH}\\dotnet.exe\" build \"${SOLUTION_PATH}\" --no-restore --configuration Release"
            }
        }

        stage('Run Tests') {
            steps {
                echo 'Running tests...'
                bat "\"${DOTNET_PATH}\\dotnet.exe\" test \"${SOLUTION_PATH}\" --no-build --logger:trx"
            }
        }
    }

    post {
        always {
            echo 'Cleaning workspace...'
            cleanWs()
        }
        success {
            echo 'Build and tests completed successfully!'
        }
        failure {
            echo 'Build or tests failed.'
        }
    }
}
