pipeline {
    agent any

    environment {
        DOTNET_PATH = 'C:\\Program Files\\dotnet' // Path to .NET SDK
        CHROME_DRIVER_PATH = 'C:\\Users\\venkatesh.b\\Desktop\\DailyCheck_WebAutomation\\packages\\Selenium.WebDriver.ChromeDriver.90.0.4430.2400' // Path to ChromeDriver
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
                bat '"${DOTNET_PATH}\\dotnet.exe" restore "C:\\Users\\venkatesh.b\\Desktop\\DailyCheck_WebAutomation"'
            }
        }

        stage('Build') {
            steps {
                echo 'Building the solution...'
                bat '"${DOTNET_PATH}\\dotnet.exe" build "C:\\Users\\venkatesh.b\\Desktop\\DailyCheck_WebAutomation" --no-restore --configuration Release'
            }
        }

        stage('Run Tests') {
            steps {
                echo 'Running tests with SpecFlow...'
                bat """
                SET CHROME_DRIVER_PATH=${CHROME_DRIVER_PATH}
                "${DOTNET_PATH}\\dotnet.exe" test "C:\\Users\\venkatesh.b\\Desktop\\DailyCheck_WebAutomation" --no-build --logger:trx
                """
            }
        }

        stage('Publish Results') {
            steps {
                echo 'Publishing test results...'
                publishHTML([allowMissing: false,
                             alwaysLinkToLastBuild: true,
                             keepAll: true,
                             reportDir: 'TestResults',
                             reportFiles: 'index.html',
                             reportName: 'Test Report'])
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
