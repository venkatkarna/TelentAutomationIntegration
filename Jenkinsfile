pipeline {
    agent any

    environment {
        // If needed, define dotnet path (adjust if you want to use a custom path)
        DOTNET_PATH = 'C:\\Program Files\\dotnet'  // Ensure this path is correct for your environment
    }

    stages {
        stage('Checkout') {
            steps {
                echo 'Checking out the code...'
                checkout scm
                bat 'dir'  // List contents of workspace to ensure correct files are present
            }
        }

        stage('Restore Dependencies') {
            steps {
                script {
                    echo 'Restoring NuGet dependencies...'
                    def solutionPath = 'DailyCheck_WebAutomation.sln'  // Adjust if necessary
                    echo "Restoring solution: ${solutionPath}"
                    
                    // Execute 'dotnet restore'
                    def restore = bat(script: "\"${DOTNET_PATH}\\dotnet.exe\" restore \"${solutionPath}\"", returnStatus: true)
                    if (restore != 0) {
                        error "Error: Restore failed!"
                    }
                }
            }
        }

        stage('Build') {
    steps {
        echo 'Building the solution...'
        bat "dotnet build DailyCheck_WebAutomation.sln --configuration Debug -p:TargetFramework=net461"
    }
}


        stage('Run Tests') {
            steps {
                script {
                    echo 'Running tests...'
                    def solutionPath = 'DailyCheck_WebAutomation.sln'  // Adjust if necessary
                    // Assuming tests are in the solution defined in Build stage
                    def test = bat(script: "\"${DOTNET_PATH}\\dotnet.exe\" test \"${solutionPath}\" --no-build --logger:trx", returnStatus: true)
                    if (test != 0) {
                        error "Error: Tests failed!"
                    }
                }
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
