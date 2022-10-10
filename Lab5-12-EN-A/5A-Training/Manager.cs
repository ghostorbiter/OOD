namespace _5A_Training
{
    class Manager
    {
        // TODO: finish implementation
        private Task _task;

        public void SelectTrainingProgramme(Task task)
        {
            _task = task;
        }

        public void StartTraining()
        {
            _task.Train();
        }
    }
}