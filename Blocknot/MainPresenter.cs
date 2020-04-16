using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blocknot.BL;

namespace Blocknot
{
    class MainPresenter
    {
        private readonly IMainForm _view;
        private readonly IFileMamger _manager;
        private readonly IMessageService _service;
        private string _currentFilePath;

        public MainPresenter(IMainForm view, IFileMamger manager, IMessageService service)
        {
            _view = view;
            _manager = manager;
            _service = service;

            _view.SetSymbol(0);
            _view.ContentChanget += _view_ContentChanget;

            _view.FileOpenClick += _view_FileOpenClick;
            _view.FileSaveClick += _view_FileSaveClick;

        }

        private void _view_FileSaveClick(object sender, EventArgs e)
        {
            try
            {
                string content = _view.Content;

                _manager.SaveContent(content, _currentFilePath);
                _service.ShowMessage("Файл успешно сохранен");


            }
            catch (Exception ex)
            {
                _service.ShowError(ex.Message);
                
            }
        }

        private void _view_FileOpenClick(object sender, EventArgs e)
        {
            try
            {
                string filePath = _view.FilePath;

                bool isExit = _manager.IsExit(filePath);

                if(!isExit)
                {
                    _service.ShowExalamation("Выбранный файл не существует");
                    return;
                }

                 _currentFilePath = filePath;

                string content = _manager.GetContent(filePath);
                int count = _manager.GetSymbolCount(content);

                _view.Content = content;
                _view.SetSymbol(count);

            }
            catch (Exception ex)
            {

                _service.ShowError(ex.Message);
            }
        }

        private void _view_ContentChanget(object sender, EventArgs e)
        {
            string content = _view.Content;

            int count = _manager.GetSymbolCount(content);

            _view.SetSymbol(count);
        }
    }
}
