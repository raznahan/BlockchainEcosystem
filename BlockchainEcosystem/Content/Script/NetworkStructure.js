var len = undefined;
// create a network
var container = document.getElementById('graph');
var data = @Html.Raw(Json.Encode(Model))
var options = {
    edges: {
        arrows: {
            to: { enabled: true, scaleFactor: 1, type: 'arrow' },
        },
        hoverWidth: 1,
        smooth: {
            enabled: true,
            type: 'cubicBezier',
            roundness: 0
        }
    },
    nodes: {
        borderWidth: 4,
        shape: 'circularImage',
        shapeProperties: {
            useBorderWithImage: true
        },
        size: 20,
        font: {
            face: 'Sahel',
            color: 'white'
        }
    },
    physics: {
        solver: 'barnesHut',
        barnesHut: {
            gravitationalConstant: -8000,
            centralGravity: 0.8,
            springLength: 95,
            springConstant: 0.04,
            damping: 0.1,
            avoidOverlap: 0.3
        },
        stabilization: {
            enabled: true,
            iterations: 3000,
            updateInterval: 100,
            onlyDynamicEdges: false,
            fit: true
        },
    },
    layout: {
        randomSeed: 1,
    }
};
network = new vis.Network(container, data, options);