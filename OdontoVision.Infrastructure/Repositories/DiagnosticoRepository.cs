using OdontoVision.Domain.Entities;
using OdontoVision.Domain.Interfaces;
using System.Collections.Generic;

namespace OdontoVision.Infrastructure.Repositories
{
    public class DiagnosticoRepository : IDiagnosticoRepository
    {
        // Simulação de contexto do banco de dados
        private readonly List<Diagnostico> _diagnosticos = new List<Diagnostico>();

        public void Adicionar(Diagnostico diagnostico)
        {
            _diagnosticos.Add(diagnostico);
        }

        public Diagnostico GetById(int id)
        {
            return _diagnosticos.Find(d => d.Id == id);
        }

        public IEnumerable<Diagnostico>? ObterTodos()
        {
            return _diagnosticos;
        }

        public void Atualizar(Diagnostico diagnostico)
        {
            var existing = GetById(diagnostico.Id);
            if (existing != null)
            {
                existing.Descricao = diagnostico.Descricao;
                existing.Data = diagnostico.Data;
                existing.PacienteId = diagnostico.PacienteId;
                existing.DentistaId = diagnostico.DentistaId;
            }
        }

        public void Remover(int id)
        {
            var diagnostico = GetById(id);
            if (diagnostico != null)
            {
                _diagnosticos.Remove(diagnostico);
            }
        }
    }
}
